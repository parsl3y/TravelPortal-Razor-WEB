using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using TravelPortalBlazor.Core.Entity;
using TravelPortalBlazor.Service.Services.PlaceFamousService;

namespace TravelPortalBlazor.Service.Services
{
    public class ClientPlaceFamousService : IPlaceFamousService
    {
        private readonly HttpClient _httpClient;

        public ClientPlaceFamousService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PlaceFamous> CreateAsync(PlaceFamous place)
        {
            var result = await _httpClient.PostAsJsonAsync<PlaceFamous>("/api/place", place);
            return await result.Content.ReadFromJsonAsync<PlaceFamous>();
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var result = await _httpClient.DeleteAsync($"/api/place/{id}");
            return await result.Content.ReadFromJsonAsync<bool>();
        }

        public async Task<PlaceFamous> UpdateAsync(Guid id, PlaceFamous place)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/place/{id}", place);
            return await result.Content.ReadFromJsonAsync<PlaceFamous>();
        }

        public async Task<IEnumerable<PlaceFamous>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("/api/place");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<IEnumerable<PlaceFamous>>();
        }

        public async Task<PlaceFamous> GetByIdAsync(Guid id)
        {
            var result = await _httpClient.GetFromJsonAsync<PlaceFamous>($"/api/place/{id}");
            return result;
        }

        public Task<string> GetCityNameById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
