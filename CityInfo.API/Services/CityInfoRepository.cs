using CityInfo.API.Data;
using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.Services
{
    public class CityInfoRepository : ICityInfoRepository
    {
        private readonly CityInfoDbContext _context;
        public CityInfoRepository(CityInfoDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<City>> GetCitiesAsync()
        {
            return await _context.cities.OrderBy(c => c.Name).ToListAsync();
        }

        public async Task<City?> GetCity(int cityId, bool IncludePointOfInterest)
        {
            if (IncludePointOfInterest)
            {
                return await _context.cities.Include(c => c.PointOfInterests).Where(c => c.Id == cityId).FirstOrDefaultAsync();
            }

            return await _context.cities.Where(c => c.Id == cityId).FirstOrDefaultAsync();
        }

        public async Task<PointOfInterests?> GetOfInterestForCityAsync(int cityId, int pointOfInterestId)
        {
            return await _context.pointOfInterests.Where(c => c.CityId == cityId && c.Id == pointOfInterestId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<PointOfInterests>> GetPointOfInterestsForCityAsync(int CityId)
        {
            return await _context.pointOfInterests.ToListAsync();
        }
    }
}
