using System;
using System.Threading.Tasks;
using TravelPortalBlazor.Core.Entity;
using TravelPortalBlazor.Service.Services.IService;

namespace TravelPortalBlazor.Service.Services.HotelService
{
    public interface IHotelService : IEntityService<Hotel, Guid>
    {
        Task<string> GetCityNameById(Guid id);
    }
}
