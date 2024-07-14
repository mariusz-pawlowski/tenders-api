using MediatR;
using Tenders.Api.Contracts.Endpoints;
using Tenders.Api.Contracts.Models;

namespace Tenders.Api.Application.Queries
{
    public class GetTendersForSupplierQuery : IRequest<IEnumerable<TenderData>>
    {
        public GetTendersForSupplierQuery(GetTendersForSupplierParameters parameters)
        {
            SupplierId = parameters.SupplierId;

            Paging.PageNumber = parameters.PageNumber;
            Paging.PageSize = parameters.PageSize;
        }
        public string SupplierId { get; set; }
        public Paging Paging { get; set; } = Paging.Default();
    }
}
