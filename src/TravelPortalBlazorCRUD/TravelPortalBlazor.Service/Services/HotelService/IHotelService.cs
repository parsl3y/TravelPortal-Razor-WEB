using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPortalBlazor.Core.Entity;
using TravelPortalBlazor.Core.Entity.Interface;
using TravelPortalBlazor.Service.Services.IService;

namespace TravelPortalBlazor.Service.Services.HotelService
{
    public interface IHotelService : IEntityService<Hotel, Guid>
    {
     
    }
}
