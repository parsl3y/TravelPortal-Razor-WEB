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

        public async Task <bool> DeleteCity(int id)
        {
            var result = await _httpClient.DeleteAsync($"/api/city/{id}");
            return await result.Content.ReadFromJsonAsync<bool>();
        }

        public async Task <City> EditCity(int id, City city)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/city/{id}", city);
            return await result.Content.ReadFromJsonAsync<City>();
        }

        public async Task<List<City>> GetAllCity()
        {
            throw new NotImplementedException();
        }

        public async Task<City> GetCityById(int id)
        {
            var result = await _httpClient
                .GetFromJsonAsync<City>($"/api/city/{id}");
            return result;
        }
    }
}
