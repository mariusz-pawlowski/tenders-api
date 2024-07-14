namespace Tenders.Api.Contracts.Settings
{
    public class TendersApiExternal
    {
        public string BaseUrl { get; set; } = string.Empty;

        public int CacheRefreshIntervalInSeconds { get; set; } = 60;
    }
}
