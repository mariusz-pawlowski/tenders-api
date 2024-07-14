using MediatR;
using Tenders.Api.Contracts.Endpoints;
using Tenders.Api.Contracts.Models;

namespace Tenders.Api.Application.Queries
{
    public class GetTenderQuery : IRequest<TenderData?>
    {
        public GetTenderQuery(GetTenderParameters parameters)
        {
            TenderId = parameters.TenderId;
        }

        public string TenderId { get; set; }
    }
}
