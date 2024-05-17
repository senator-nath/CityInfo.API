using CityInfo.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        [HttpGet("api/cities")]
        public ActionResult<IEnumerable<citiesDtos>> GetCities()
        {
            return Ok(CitiesDataStore.current.Cities);

        }
        [HttpGet("api/cities/{id}")]
        public ActionResult<IEnumerable<citiesDtos>> GetCity(int id)
        {

            var cityToReturn = CitiesDataStore.current.Cities.FirstOrDefault(c => c.Id == id);
            if (cityToReturn == null)
            {
                return NotFound();
            }
            return Ok(cityToReturn);
        }
    }
}
