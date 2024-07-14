namespace Tenders.Api.Application.Queries
{
    public class FilterTendersFilters
    {
        public decimal? PriceEuroFrom { get; set; }
        public decimal? PriceEuroTo { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }

        public static FilterTendersFilters NoFilters()
        {
            return new FilterTendersFilters();
        }
    }
}
