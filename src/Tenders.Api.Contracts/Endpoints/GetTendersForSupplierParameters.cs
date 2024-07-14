using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Tenders.Api.Contracts.Endpoints
{
    public class GetTendersForSupplierParameters
    {
        [Required]
        [FromRoute(Name = "id")]
        public string SupplierId { get; set; } = default!;

        [FromHeader(Name = "x-page-number")]
        public int PageNumber { get; set; } = 1;

        [FromHeader(Name = "x-page-size")]
        public int PageSize { get; set; } = 100;
    }
}
