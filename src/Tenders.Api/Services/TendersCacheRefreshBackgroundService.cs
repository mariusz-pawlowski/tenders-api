using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
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
                    await RefreshCacheAsync(stoppingToken);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error occurred while refreshing cache");
                }

                var cacheRefreshInterval = _tendersApiExternalSettings.CacheRefreshIntervalInSeconds;
                await Task.Delay(TimeSpan.FromSeconds(cacheRefreshInterval), stoppingToken);
            }
        }

        private async Task RefreshCacheAsync(CancellationToken cancellationToken)
        {
            var tendersData = await LoadTendersDataAsync(cancellationToken);
            _cache.Set(Contracts.Cache.CacheKeys.Tenders, tendersData, TimeSpan.FromMinutes(15));
        }

        private async Task<JArray> LoadTendersDataAsync(CancellationToken cancellationToken)
        {
            var tasks = new List<Task<JArray>>();
            for (int i = 0; i < 10; i++) //load data in parallel
            {
                var startIndex = 1 + i * 10;
                tasks.Add(GetTendersAsync(Enumerable.Range(startIndex, 10), cancellationToken));
            }
            JArray[] results = await Task.WhenAll(tasks);
            JArray mergedResults = new JArray();
            foreach (var result in results)
            {
                mergedResults.Merge(result);
            }
            return mergedResults;
        }

        private async Task<JArray> GetTendersAsync(IEnumerable<int> pageNumbers, CancellationToken cancellationToken)
        {
            using var client = _httpClientFactory.CreateClient();

            JArray tendersData = [];
            foreach(var pageNumber in pageNumbers)
            {
                var response = await client.GetAsync($"{_tendersApiExternalSettings.BaseUrl}/tenders?page={pageNumber}");
                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Unable to load data for pageNumber: {pageNumber}");
                    continue;
                }

                response.EnsureSuccessStatusCode();
                var jsonString = await response.Content.ReadAsStringAsync(cancellationToken);
                var jsonToken = JToken.Parse(jsonString);
                tendersData.Merge(jsonToken["data"] as JArray);
            }
            return tendersData;
        }
    }
}
