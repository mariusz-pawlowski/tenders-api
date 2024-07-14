using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Caching.Memory;

namespace Tenders.Api.Tests.Mock
{
    public class CustomWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                // Remove the existing IMemoryCache service registration
                var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(IMemoryCache));
                if (descriptor != null)
                {
                    services.Remove(descriptor);
                }

                // Add the mock IMemoryCache service registration
                var memoryCache = MockMemoryCache.Create();
                memoryCache.Set(Contracts.Cache.CacheKeys.Tenders, MockResponse.TendersApiResponse);
                services.AddSingleton<IMemoryCache>(memoryCache);
            });
        }
    }
}
