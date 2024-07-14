using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Tenders.Api.Contracts.Settings;

namespace Tenders.Api.Services
{
    public class TendersCacheRefreshBackgroundService : BackgroundService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IMemoryCache _cache;
        private readonly TendersApiExternal _tendersApiExternalSettings;

        public TendersCacheRefreshBackgroundService(IMemoryCache cache, IHttpClientFactory httpClientFactory, IOptions<TendersApiExternal> tendersApiExternalSettings)
        {
            _cache = cache;
            _httpClientFactory = httpClientFactory;
            _tendersApiExternalSettings = tendersApiExternalSettings.Value;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    await RefreshCacheAsync();
                }
                catch (Exception)
                {
                    Console.WriteLine("Error occurred while refreshing cache");
                }

                var cacheRefreshInterval = _tendersApiExternalSettings.CacheRefreshIntervalInSeconds;
                await Task.Delay(TimeSpan.FromSeconds(cacheRefreshInterval), stoppingToken);
            }
        }

        private async Task RefreshCacheAsync()
        {
            using var client = _httpClientFactory.CreateClient();
            var tenders = await client.GetFromJsonAsync<object>($"{_tendersApiExternalSettings.BaseUrl}/tenders");

            if (tenders != null)
            {
                _cache.Set(Contracts.Cache.CacheKeys.Tenders, tenders, TimeSpan.FromMinutes(3));
            }
        }
    }
}
