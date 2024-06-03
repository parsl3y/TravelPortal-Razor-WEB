using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPortalBlazor.Core.Entity;
using TravelPortalBlazor.Service.Services.IService;

namespace TravelPortalBlazor.Service.Services.PlaceFamousService
{
    public interface IPlaceFamousService: IEntityService<PlaceFamous, Guid>
    {
    }
}
