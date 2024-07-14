using Microsoft.Extensions.Caching.Memory;
using Moq;

namespace Tenders.Api.Tests.Mock
{
    public class MockMemoryCache
    {
        public static IMemoryCache Create()
        {
            var mockMemoryCache = new Mock<IMemoryCache>();
            var internalCache = new MemoryCache(new MemoryCacheOptions());

            // Setup for adding items to the cache
            mockMemoryCache.Setup(cache => cache.CreateEntry(It.IsAny<object>()))
                           .Returns((object key) =>
                           {
                               var entry = internalCache.CreateEntry(key);
                               entry.RegisterPostEvictionCallback((callbackKey, value, reason, state) =>
                               {
                                   internalCache.Remove(callbackKey);
                               });
                               return entry;
                           });

            // Setup for retrieving items from the cache
            mockMemoryCache.Setup(cache => cache.TryGetValue(Contracts.Cache.CacheKeys.Tenders, out It.Ref<object>.IsAny!))
                           .Returns((object key, out object value) =>
                           {
                               return internalCache.TryGetValue(key, out value!);
                           });

            return mockMemoryCache.Object;
        }
    }
}
