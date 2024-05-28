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
    }
}
