using CityInfo.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/cities/{cityId}/pointOfInterests")]
    [ApiController]
    public class PointOfInterestController : ControllerBase
    {
        [HttpGet]

        public ActionResult<IEnumerable<PointOfInterestDto>> GetPointOfInterests(int cityId)
        {
            var city = CitiesDataStore.current.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null)
            {
                return NotFound();
            }
            return Ok(city.PointOfInterests);
        }

        [HttpGet("{pointOfInterestId}")]
        public ActionResult<PointOfInterestDto> GetPointOfInterest(int cityId, int pointOfInterestId)
        {
            var city = CitiesDataStore.current.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null)
            {
                return NotFound();
            }

            var pointOfInterest = city.PointOfInterests.FirstOrDefault(c => c.Id == pointOfInterestId);
            if (city == null)
            {
                return NotFound();
            }

            return Ok(pointOfInterest);
        }
    }
}
