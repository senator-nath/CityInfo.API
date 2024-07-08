using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.Data
{
    public class CityInfoDbContext : DbContext
    {
        public CityInfoDbContext(DbContextOptions<CityInfoDbContext> options) : base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<City>().HasData(

        //        );
        //    base.OnModelCreating(modelBuilder);
        //}
        public DbSet<City> cities { get; set; }
        public DbSet<PointOfInterest> pointOfInterests { get; set; }
    }
}
