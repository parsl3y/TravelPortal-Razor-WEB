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
        //private readonly DataContext _ctx;

        //public HotelService(DataContext context)
        //{
        //    _ctx = context;
        //}

        //public async Task<Hotel> AddHotel(Hotel hotel)
        //{
        //    _ctx.Hotel.Add(hotel);
        //    await _ctx.SaveChangesAsync();

        //    return hotel;
        //}

        //public async Task<bool> DeleteHotel(Guid id)
        //{
        //    var dbCity = await _ctx.Hotel.FindAsync(id);
        //    if (dbCity != null)
        //    {
        //        _ctx.Remove(dbCity);
        //        await _ctx.SaveChangesAsync();
        //        return true;
        //    }
        //    return false;
        //}

        //public async Task<Hotel> EditHotels(Guid id, Hotel hotel)
        //{
        //    var dbCity = await _ctx.Hotel.FindAsync(id);
        //    if (dbCity != null)
        //    {
        //        dbCity.name = hotel.name;
        //        await _ctx.SaveChangesAsync();
        //        return dbCity;
        //    }
        //    throw new Exception("Hotel not Faund");
        //}

        //public async Task<List<Hotel>> GetAllHotel()
        //{
        //    await Task.Delay(1000);

        //    var hotels = await _ctx.Hotel.ToListAsync();
        //    return hotels;
        //}

        //public async Task<Hotel> GetHotelById(Guid id)
        //{
        //    return await _ctx.Hotel.FindAsync(id);
        //}
    }
}
