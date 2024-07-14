using Microsoft.AspNetCore.Mvc;
using Tenders.Api.Contracts.Models;

namespace Tenders.Api.Contracts.Endpoints
{
    public class GetTendersFilteredParameters
    {
        [FromQuery]
        public decimal? PriceEuroFrom { get; set; }
        [FromQuery]
        public decimal? PriceEuroTo { get; set; }
        [FromQuery]
        public DateTime? DateFrom { get; set; }
        [FromQuery]
        public DateTime? DateTo { get; set; }
        [FromQuery]
        public OrderBy? OrderByDate { get; set; }
        [FromQuery]
        public OrderBy? OrderByPriceEuro { get; set; }


        [FromHeader(Name = "x-page-number")]
        public int PageNumber { get; set; } = 1;

        [FromHeader(Name = "x-page-size")]
        public int PageSize { get; set; } = 100;
    }
}
