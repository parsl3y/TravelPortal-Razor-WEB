using System.Net.Http.Json;
using TravelPortalBlazor.Core.Entity;
using TravelPortalBlazor.Service.Services.CityService;

namespace TravelPortalBlazor.Service.Services
{
    public class ClientCityService : ICityService
    {
        private readonly HttpClient _httpClient;

        public ClientCityService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<City> AddCity(City city)
        {
            var result = await _httpClient.PostAsJsonAsync<City>("/api/city", city);
            return await result.Content.ReadFromJsonAsync<City>();
        }

        public async Task<bool> DeleteCity(Guid id)
        {
            var result = await _httpClient.DeleteAsync($"/api/city/{id}");
            return await result.Content.ReadFromJsonAsync<bool>();
        }

        public async Task<City> EditCity(Guid id, City city)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/city/{id}", city);
            return await result.Content.ReadFromJsonAsync<City>();
        }

        public async Task<List<City>> GetAllCity()
        {
            var response = await _httpClient.GetAsync("/api/cities");
            response.EnsureSuccessStatusCode();

            var cities = await response.Content.ReadFromJsonAsync<List<City>>();

            return cities;
        }

        public async Task<City> GetCityById(Guid id)
        {
            var result = await _httpClient
                .GetFromJsonAsync<City>($"/api/city/{id}");
            return result;
        }

        public async Task<string> GetCityNameById(Guid id)
        {
            var city = await GetCityById(id);
            return city?.Name;
        }
    }
}
