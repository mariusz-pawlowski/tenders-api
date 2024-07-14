namespace TendersAPI.Models
{
    public class FilterModel
    {
        public decimal? PriceEuroFrom { get; set; }
        public decimal? PriceEuroTo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
