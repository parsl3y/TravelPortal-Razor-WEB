using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TravelPortalBlazor.Core.Entity;
using TravelPortalBlazor.Service.Services.HotelService;
using TravelPortalBlazor.Service.Services.PlaceFamousService;

namespace TravelPortalBlazorCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceFamousController : ControllerBase
    {
        private readonly IPlaceFamousService _placeService;

        public PlaceFamousController(IPlaceFamousService placeService)
        {
            _placeService = placeService;
        }

        [HttpPost]
        public async Task<ActionResult<PlaceFamous>> AddPlace(PlaceFamous place)
        {
            var addedplace = await _placeService.CreateAsync(place);
            return Ok(addedplace);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<City>> EditPlace(Guid id, PlaceFamous place)
        {
            var updateplace = await _placeService.UpdateAsync(id, place);
            return Ok(updateplace);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PlaceFamous>> DeletePlace(Guid id)
        {
            var result = await _placeService.DeleteAsync(id);
            return Ok(result);
        }
    }
}
