using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using TravelPortalBlazor.Core.Entity;
using TravelPortalBlazor.Service.Services.CityService;

namespace TravelPortalBlazorCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpPost]
        public async Task<ActionResult<City>> AddCity(City city)
        {
            var addedCity = await _cityService.AddCity(city);
            return Ok(addedCity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<City>> EditCity(Guid id, City city)
        {
            var updateCity =  await _cityService.EditCity(id, city);
            return Ok(updateCity);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<City>> DeleteCity(Guid id)
        {
            var result = await _cityService.DeleteCity(id);
            return Ok(result);
        }
    }
}
