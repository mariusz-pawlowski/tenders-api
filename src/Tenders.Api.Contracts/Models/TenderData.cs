namespace Tenders.Api.Contracts.Models
{
    public class TenderData
    {
        public string Id { get; set; } = string.Empty;
        public DateOnly? Date { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public decimal? AmountInEuro { get; set; }
        public ICollection<SuppliersData>? Suppliers { get; set; }
        public string? SuppliersId { get; set; }
        public string? SuppliersName { get; set; }
    }
}
