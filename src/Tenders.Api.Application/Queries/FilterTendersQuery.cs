using MediatR;
using Tenders.Api.Contracts.Endpoints;
using Tenders.Api.Contracts.Models;

namespace Tenders.Api.Application.Queries
{
    public class FilterTendersQuery : IRequest<IEnumerable<TenderData>>
    {
        public FilterTendersQuery(GetTendersFilteredParameters parameters)
        {
            if(parameters.PriceEuroFrom.HasValue)
                Filters.PriceEuroFrom = parameters.PriceEuroFrom.Value;
            if (parameters.PriceEuroTo.HasValue)
                Filters.PriceEuroTo = parameters.PriceEuroTo.Value;
            if (parameters.DateFrom.HasValue)
                Filters.DateFrom = parameters.DateFrom;
            if (parameters.DateTo.HasValue)
                Filters.DateTo = parameters.DateTo;

            if (parameters.OrderByDate.HasValue)
                Ordering.OrderByDate = parameters.OrderByDate.Value;
            if (parameters.OrderByPriceEuro.HasValue)
                Ordering.OrderByPriceEuro = parameters.OrderByPriceEuro.Value;
           
            Paging.PageNumber = parameters.PageNumber;
            Paging.PageSize = parameters.PageSize;
        }

        public FilterTendersFilters Filters = FilterTendersFilters.NoFilters();

        public Ordering Ordering { get; set; } = Ordering.NoOrdering();

        public Paging Paging { get; set; } = Paging.Default();
    }
}
