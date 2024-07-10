using AutoMapper;
using CityInfo.API.Model;
using CityInfo.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICityInfoRepository _cityInfo;
        private readonly IMapper _mapper;

        public CitiesController(ICityInfoRepository cityInfo, IMapper mapper)
        {
            _cityInfo = cityInfo;
            _mapper = mapper;
        }
        [HttpGet("api/cities")]
        public async Task<ActionResult<IEnumerable<CitiesWithoutPointOfInterestDto>>> GetCities()
        {
            var cityEntities = await _cityInfo.GetCitiesAsync();
            //var result = new List<CitiesWithoutPointOfInterestDto>();
            //foreach (var city in cityEntities)
            //{
            //    result.Add(new CitiesWithoutPointOfInterestDto
            //    {
            //        Id = city.Id,
            //        Name = city.Name,
            //        Description = city.Description,
            //    });

            //}
            return Ok(_mapper.Map<IEnumerable<CitiesWithoutPointOfInterestDto>>(cityEntities));
        }
        [HttpGet("api/cities/{id}")]
        public ActionResult<IEnumerable<citiesDtos>> GetCity(int id)
        {

            //////var cityToReturn = _dataStore.Cities.FirstOrDefault(c => c.Id == id);
            //////if (cityToReturn == null)
            //////{
            //////    return NotFound();
            //////}
            //return Ok(cityToReturn);
            return Ok();
        }
    }
}
