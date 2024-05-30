using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TravelPortalBlazor.Core.Entity;
using TravelPortalBlazor.Service.Services.CityService;
using TravelPortalBlazor.Service.Services.HotelService;

namespace TravelPortalBlazorCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpPost]
        public async Task<ActionResult<Hotel>> AddHotel(Hotel hotel)
        {
            var addedhotel = await _hotelService.CreateAsync(hotel);
            return Ok(addedhotel);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<City>> EditHotel(Guid id, Hotel hotel)
        {
            var updateHotel = await _hotelService.UpdateAsync(id, hotel);
            return Ok(updateHotel);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Hotel>> DeleteHotel(Guid id)
        {
            var result = await _hotelService.DeleteAsync(id);
            return Ok(result);
        }
    }
}
