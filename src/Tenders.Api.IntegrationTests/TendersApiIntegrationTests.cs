using Tenders.Api.Tests.Mock;
using Xunit;
using Tenders.Api.Contracts.Models;
using Newtonsoft.Json;
using Assert = Xunit.Assert;

namespace Tenders.Api.Tests
{

    public class TendersApiIntegrationTests : IClassFixture<CustomWebApplicationFactory<Program>>
    {
        private readonly CustomWebApplicationFactory<Program> _factory;

        public TendersApiIntegrationTests(CustomWebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetTenders_ReturnsSuccessStatusCode() //User should be able to retrieve tenders.
        {
            // Arrange
            using var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/tenders"); // api/tenders

            // Assert
            response.EnsureSuccessStatusCode();
            var responseData = await ReadAndDeserializeAsync<List<TenderData>>(response);

            Assert.Equal(100, responseData.Count);
        }

        [Fact]
        public async Task GetTenders_FilterByPriceEuro_ReturnsSuccess() //User should be able to filter tenders by price in EUR.
        {
            // Arrange
            using var client = _factory.CreateClient();
            int priceEuroFrom = 800;
            int priceEuroTo = 900;

            // Act
            var response = await client.GetAsync($"/api/tenders?PriceEuroFrom={priceEuroFrom}&PriceEuroTo={priceEuroTo}"); // api/tenders?PriceEuroFrom=800&PriceEuroTo=900

            // Assert
            response.EnsureSuccessStatusCode();
            var responseData = await ReadAndDeserializeAsync<List<TenderData>>(response);
            var sampleRecord = responseData.First();
            Assert.True(sampleRecord.AmountInEuro >= priceEuroFrom);
            Assert.True(sampleRecord.AmountInEuro <= priceEuroTo);
        }

        [Fact]
        public async Task GetTenders_OrderByPriceInEuro_ReturnsSuccess() //User should be able to retrieve tenders ordered by price in EUR.
        {
            // Arrange
            using var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync($"/api/tenders?OrderByPriceEuro=DESC"); // api/tenders??OrderByPriceEuro=DESC

            // Assert
            response.EnsureSuccessStatusCode();
            var responseData = await ReadAndDeserializeAsync<List<TenderData>>(response);


            var amountsInEuro = responseData.Where(rd => rd.AmountInEuro.HasValue).Select(rd => rd.AmountInEuro!.Value).ToList();
            Assert.True(IsOrderedAsync(amountsInEuro));
        }

        [Fact]
        public async Task GetTenders_FilterByDate_ReturnsSuccess() //User should be able to filter tenders by date.
        {
            // Arrange
            using var client = _factory.CreateClient();
            var dateFrom = new DateOnly(2021,07,26);
            var dateTo = new DateOnly(2021, 07, 27);

            // Act
            var response = await client.GetAsync($"/api/tenders?DateFrom={dateFrom:yyyy-MM-dd}&DateTo={dateTo:yyyy-MM-dd}"); // api/tenders?DateFrom=2021-07-26&DateTo=2021-07-27

            // Assert
            response.EnsureSuccessStatusCode();
            var responseData = await ReadAndDeserializeAsync<List<TenderData>>(response);
            var sampleRecord = responseData.First();
            Assert.True( sampleRecord.Date >= dateFrom);
            Assert.True(sampleRecord.Date <= dateTo.AddDays(1));
        }

        [Fact]
        public async Task GetTenders_OrderByDate_ReturnsSuccess() //User should be able to retrieve tenders ordered by date.
        {
            // Arrange
            using var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync($"/api/tenders?OrderByDate=ASC"); // api/tenders??OrderByDate=ASC

            // Assert
            response.EnsureSuccessStatusCode();
            var responseData = await ReadAndDeserializeAsync<List<TenderData>>(response);


            var dates = responseData.Where(rd => rd.Date.HasValue).Select(rd => rd.Date!.Value).ToList();
            
            Assert.True(dates[2] > dates[1]);
            Assert.True(dates.Last() > dates.First());
        }


        [Fact]
        public async Task GetTendersForGivenSupplierId_ReturnsSuccess() //User should be able to retrieve tenders won by a given supplier by providing supplier’s ID
        {
            // Arrange
            using var client = _factory.CreateClient();

            var supplierId = "23072";
            // Act
            var response = await client.GetAsync($"/api/suppliers/{supplierId}/tenders"); // api/suppliers/23072/tenders

            // Assert
            response.EnsureSuccessStatusCode();
            var responseData = await ReadAndDeserializeAsync<List<TenderData>>(response);

            Assert.Equal(2, responseData.Count);
        }

        [Fact]
        public async Task GetTenderById_ReturnsSuccess() // User should be able to retrieve tender with a given ID.
        {
            // Arrange
            using var client = _factory.CreateClient();
            var tenderId = "564243";

            // Act
            var response = await client.GetAsync($"/api/tenders/{tenderId}");

            // Assert
            response.EnsureSuccessStatusCode();
            var tenderData = await ReadAndDeserializeAsync<TenderData>(response);

            Assert.NotNull(tenderData);
        }

        [Fact]
        public async Task GetTenders_WhenPagingApplied_ReturnsSuccess() //Each endpoint must support pagination.
        {
            // Arrange
            using var client = _factory.CreateClient();
            client.DefaultRequestHeaders.Add("x-page-size", "11");

            // Act
            var response = await client.GetAsync("/api/tenders"); // api/tenders

            // Assert
            response.EnsureSuccessStatusCode();
            var responseData = await ReadAndDeserializeAsync<List<TenderData>>(response);

            Assert.Equal(11, responseData.Count);
        }

        private async Task<T> ReadAndDeserializeAsync<T>(HttpResponseMessage response)
        {
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }

        public static bool IsOrderedAsync(List<decimal> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i+1] >= list[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}