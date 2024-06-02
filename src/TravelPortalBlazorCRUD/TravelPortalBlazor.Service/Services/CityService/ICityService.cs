using TravelPortalBlazor.Core.Entity;
namespace TravelPortalBlazor.Service.Services.CityService
{
    public interface ICityService
    {
        Task<List<City>> GetAllCity();
        Task<City> AddCity(City city);
        Task<City> GetCityById(Guid id);
        Task<City> EditCity (Guid id, City city);
        Task<bool> DeleteCity(Guid id);
        Task<string> GetCityNameById(Guid id);
    }
}
