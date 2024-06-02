using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPortalBlazor.Core.Context;
using TravelPortalBlazor.Core.Entity;
using TravelPortalBlazor.Service.Services.IService;

namespace TravelPortalBlazor.Service.Services.HotelService
{
    public class HotelService : EntityService<Hotel, Guid>, IHotelService
    {
        public HotelService(DataContext ctx) : base(ctx) { }
        public async Task<string> GetCityNameById(Guid id)
        {
            var city = await _ctx.City.FindAsync(id);
            return city?.Name;
        }
    }
}
