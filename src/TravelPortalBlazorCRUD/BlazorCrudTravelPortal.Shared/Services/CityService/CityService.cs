using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public async Task<List<City>> GetAllCity()
        {
            await Task.Delay(1000);

            var cities = await _ctx.City.ToListAsync();
            return cities;
        }

    
    }
}
