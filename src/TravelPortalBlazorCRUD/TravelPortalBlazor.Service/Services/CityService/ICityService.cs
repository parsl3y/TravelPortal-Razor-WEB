using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPortalBlazor.Core.Entity;
namespace TravelPortalBlazor.Service.Services.CityService
{
    public interface ICityService
    {
        Task<List<City>> GetAllCity();
        Task<City> AddCity(City city);
        Task<City> GetCityById(int id);
        Task<City> EditCity (int id, City city);
        Task<bool> DeleteCity(int id);
    }
}
