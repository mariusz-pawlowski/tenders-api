using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json.Linq;
using Polly;

namespace Tenders.Api.Application.Services
{
    public interface ICacheService
    {
        public JArray ReadTendersFromCacheOrThrow();
    }

    public class CacheService : ICacheService
    {
        private readonly IMemoryCache _memoryCache;
        public CacheService(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public JArray ReadTendersFromCacheOrThrow()
        {
            var retryPolicy = Policy
                .HandleResult<object?>(result => result == null)
                .WaitAndRetry(3, retryAttempt => TimeSpan.FromSeconds(3));

            var cachedValue = retryPolicy.Execute(() =>
            {
                object? cachedValue;
                if (!_memoryCache.TryGetValue(Contracts.Cache.CacheKeys.Tenders, out cachedValue))
                {
                    throw new HttpRequestException("There were problems to load tenders data");
                }
                return cachedValue;
            });
            if (cachedValue == null)
                throw new HttpRequestException("There are no data to process data");
            JToken jsonToken = JToken.Parse(cachedValue.ToString()!);
            return jsonToken["data"] as JArray
                     ?? throw new HttpRequestException("There were problems with parsing tenders data");
        }
    }
}
