using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using TravelPortalBlazor.Core.Entity;
using TravelPortalBlazor.Service.Services.HotelService;

namespace TravelPortalBlazor.Service.Services
{
    public class ClientHotelService: IHotelService
    {
        private readonly HttpClient _httpClient;

        public ClientHotelService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Hotel> CreateAsync(Hotel hotel)
        {
            var result = await _httpClient.PostAsJsonAsync<Hotel>("/api/hotel", hotel);
            return await result.Content.ReadFromJsonAsync<Hotel>();
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var result = await _httpClient.DeleteAsync($"/api/hotel/{id}");
            return await result.Content.ReadFromJsonAsync<bool>();
        }

        public async Task<Hotel> UpdateAsync(Guid id, Hotel hotel)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/hotel/{id}", hotel);
            return await result.Content.ReadFromJsonAsync<Hotel>();
        }

        public async Task<IEnumerable<Hotel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Hotel> GetByIdAsync(Guid id)
        {
            var result = await _httpClient
                .GetFromJsonAsync<Hotel>($"/api/hotel/{id}");
            return result;
        }
    }
}
