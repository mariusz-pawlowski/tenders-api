using MediatR;
using Tenders.Api.Application.Queries;
using Tenders.Api.Contracts.Models;
using Newtonsoft.Json.Linq;
using Tenders.Api.Application.Mappers;
using Microsoft.Extensions.Options;
using Tenders.Api.Contracts.Settings;

namespace Tenders.Api.Application.QueryHandlers
{
    public class GetTenderQueryHandler : IRequestHandler<GetTenderQuery, TenderData?>
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly TendersApiExternal _tendersApiExternalSettings;

        public GetTenderQueryHandler(IHttpClientFactory httpClientFactory, IOptions<TendersApiExternal> tendersApiExternalSettings)
        {
            _httpClientFactory = httpClientFactory;
            _tendersApiExternalSettings = tendersApiExternalSettings.Value;
        }

        public async Task<TenderData?> Handle(GetTenderQuery request, CancellationToken cancellationToken)
        {
            using var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"{_tendersApiExternalSettings.BaseUrl}/tenders/{request.TenderId}");
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                return null;

            response.EnsureSuccessStatusCode();
            var jsonString = await response.Content.ReadAsStringAsync(cancellationToken);
            var jsonToken = JToken.Parse(jsonString);

            return TendersMapper.MapTender(jsonToken);
        }
    }
}
