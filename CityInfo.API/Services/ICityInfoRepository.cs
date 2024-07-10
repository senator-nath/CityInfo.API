using CityInfo.API.Entities;

namespace CityInfo.API.Services
{
    public interface ICityInfoRepository
    {
        Task<IEnumerable<City>> GetCitiesAsync();
        Task<City?> GetCity(int cityId, bool IncludePointOfInterest);
        

        Task<IEnumerable<PointOfInterests>> GetPointOfInterestsForCityAsync(int CityId);

        Task<PointOfInterests?> GetOfInterestForCityAsync(int cityId, int pointOfInterestId);
    }
}
