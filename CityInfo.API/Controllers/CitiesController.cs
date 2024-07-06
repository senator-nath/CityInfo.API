using CityInfo.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly CitiesDataStore _dataStore;

        public CitiesController(CitiesDataStore dataStore)
        {
            _dataStore = dataStore;
        }
        [HttpGet("api/cities")]
        public ActionResult<IEnumerable<citiesDtos>> GetCities()
        {
            return Ok(_dataStore.Cities);

        }
        [HttpGet("api/cities/{id}")]
        public ActionResult<IEnumerable<citiesDtos>> GetCity(int id)
        {

            var cityToReturn = _dataStore.Cities.FirstOrDefault(c => c.Id == id);
            if (cityToReturn == null)
            {
                return NotFound();
            }
            return Ok(cityToReturn);
        }
    }
}
