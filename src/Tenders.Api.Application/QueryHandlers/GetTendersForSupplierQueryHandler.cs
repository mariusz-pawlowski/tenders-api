using MediatR;
using Tenders.Api.Application.Mappers;
using Tenders.Api.Application.Queries;
using Tenders.Api.Application.Services;
using Tenders.Api.Contracts.Models;

namespace Tenders.Api.Application.QueryHandlers
{
    public class GetTendersForSupplierQueryHandler : IRequestHandler<GetTendersForSupplierQuery, IEnumerable<TenderData>>
    {
        private readonly ICacheService _cache;
        public GetTendersForSupplierQueryHandler(ICacheService cache)
        {
            _cache = cache;
        }

        public Task<IEnumerable<TenderData>> Handle(GetTendersForSupplierQuery request, CancellationToken cancellationToken)
        {
            var tenders = _cache.ReadTendersFromCacheOrThrow();

            var filteredTenders = tenders.Where(tender =>
                tender["awarded"] != null &&
                tender["awarded"]!.FirstOrDefault()?["suppliers_id"]!.ToString() == request.SupplierId
            );


            var result = filteredTenders.Select(TendersMapper.MapTender);

            var pagedResult = result
               .Skip((request.Paging.PageNumber - 1) * request.Paging.PageSize)
               .Take(request.Paging.PageSize);

            return Task.FromResult(pagedResult);
        }
    }


}
