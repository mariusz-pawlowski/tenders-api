using Newtonsoft.Json.Linq;
using Tenders.Api.Contracts.Models;

namespace Tenders.Api.Application.Mappers
{
    public static class TendersMapper
    {
        public static TenderData MapTender(JToken tenderJObject)
        {
            var tenderData = new TenderData()
            {
                Id = (tenderJObject["id"] ?? string.Empty).ToString(),
                Date = tenderJObject["date"] != null ? DateOnly.Parse(tenderJObject["date"]!.ToString()) : null,
                Title = (tenderJObject["title"] ?? string.Empty).ToString(),
                Description = (tenderJObject["description"] ?? string.Empty).ToString(),
                AmountInEuro = tenderJObject["awarded_value_eur"] != null ? decimal.Parse(tenderJObject["awarded_value_eur"]!.ToString()) : null,
               
            };

            var awarded = tenderJObject["awarded"]?.FirstOrDefault();
            if (awarded != null) 
            {
                tenderData.SuppliersId = awarded["suppliers_id"] != null ? awarded["suppliers_id"]?.ToString() : null;
                tenderData.SuppliersName = awarded["suppliers_name"] != null ? awarded["suppliers_name"]?.ToString() : null;
                tenderData.Suppliers = awarded["suppliers"] != null ? awarded["suppliers"]?.Select(MapSupplier).ToList() : null;
            }
            return tenderData;
        }
            

        private static SuppliersData MapSupplier(JToken supplierJObject) =>
            new()
            {
                Id = (supplierJObject["id"] ?? string.Empty).ToString(),
                Name = (supplierJObject["name"] ?? string.Empty).ToString()
            };
    }
}
