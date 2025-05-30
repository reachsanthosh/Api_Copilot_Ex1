using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace CitiesApi.Tests
{
    public class CitiesApiTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public CitiesApiTests(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GetCities_France_ReturnsParis()
        {
            var response = await _client.GetAsync("/cities/France");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadFromJsonAsync<JsonElement>();
            Assert.Contains("Paris", json.GetProperty("cities").EnumerateArray().Select(x => x.GetString()));
        }

        [Fact]
        public async Task GetCities_Spain_ReturnsNotFound()
        {
            var response = await _client.GetAsync("/cities/Spain");
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
            var json = await response.Content.ReadFromJsonAsync<JsonElement>();
            Assert.Equal("Country not found", json.GetProperty("detail").GetString());
        }
    }
}
