using MediatR;
using Tenders.Api.Application.Mappers;
using Tenders.Api.Application.Queries;
using Tenders.Api.Contracts.Models;
using Tenders.Api.Application.Services;

namespace Tenders.Api.Application.QueryHandlers
{
    public class FilterTendersQueryHandler : IRequestHandler<FilterTendersQuery, IEnumerable<TenderData>>
    {
        private readonly ICacheService _cache;
        public FilterTendersQueryHandler(ICacheService cache)
        {
            _cache = cache;
        }

        public Task<IEnumerable<TenderData>> Handle(FilterTendersQuery request, CancellationToken cancellationToken)
        {
            var tenders = _cache.ReadTendersFromCacheOrThrow();

            var filteredTenders = tenders.Where(tender =>
                (request.Filters.PriceEuroFrom == null || decimal.Parse(tender["awarded_value_eur"]!.ToString()) >= request.Filters.PriceEuroFrom) &&
                (request.Filters.PriceEuroTo == null || decimal.Parse(tender["awarded_value_eur"]!.ToString()) <= request.Filters.PriceEuroTo) &&
                (request.Filters.DateFrom == null || DateTime.Parse(tender["date"]!.ToString()) >= request.Filters.DateFrom) &&
                (request.Filters.DateTo == null || DateTime.Parse(tender["date"]!.ToString()) <= request.Filters.DateTo)
            );


            var result = filteredTenders.Select(TendersMapper.MapTender);
            if (request.Ordering != null)
            {
                if (request.Ordering.OrderByDate != null)
                    result = request.Ordering.OrderByDate == OrderBy.ASC
                            ? result.OrderBy(r => r.Date)
                            : result.OrderByDescending(r => r.Date);

                if (request.Ordering.OrderByPriceEuro != null)
                    result = request.Ordering.OrderByPriceEuro == OrderBy.ASC
                            ? result.OrderBy(r => r.AmountInEuro)
                            : result.OrderByDescending(r => r.AmountInEuro);
            }

            var pagedResult = result
               .Skip((request.Paging.PageNumber - 1) * request.Paging.PageSize)
               .Take(request.Paging.PageSize)
               ;

            return Task.FromResult(pagedResult);
        }
    }
}
