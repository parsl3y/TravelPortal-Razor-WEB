using Microsoft.EntityFrameworkCore;
using TravelPortalBlazor.Core.Context;
using TravelPortalBlazor.Core.Entity;

namespace TravelPortalBlazor.Service.Services.CityService
{
    public class CityService : ICityService
    {
        private readonly DataContext _ctx;

        public CityService(DataContext context)
        {
            _ctx = context;
        }

        public async Task<City> AddCity(City city)
        {
            _ctx.City.Add(city);
            await _ctx.SaveChangesAsync();

            return city;
        }

        public async Task<bool> DeleteCity(int id)
        {
           var dbCity = await _ctx.City.FindAsync(id);
            if(dbCity != null)
            {
                _ctx.Remove(dbCity);
                await _ctx.SaveChangesAsync() ;
                return true;
            }
            return false;
        }

        public async Task<City> EditCity(int id, City city)
        {
            var dbCity = await _ctx.City.FindAsync(id);
            if(dbCity != null)
            {
                dbCity.Name = city.Name;
                await _ctx.SaveChangesAsync();
                return dbCity;
            }
            throw new Exception("City not Faund");
        }

        public async Task<List<City>> GetAllCity()
        {
            await Task.Delay(1000);

            var cities = await _ctx.City.ToListAsync();
            return cities;
        }

        public async Task<City> GetCityById(int id)
        {
            return await _ctx.City.FindAsync(id);
        }
    }
}
