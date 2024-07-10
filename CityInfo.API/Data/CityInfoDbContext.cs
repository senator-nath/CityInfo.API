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

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<City>().HasData(
        //        new City("Benin City")
        //        {
        //            Id = 1,
        //            Description = "the heartbeat of the nation"
        //        },
        //        new City("Lagos")
        //        {
        //            Id = 2,
        //            Description = "A land of true hustlers"
        //        },
        //        new City("Akure")
        //        {
        //            Id = 3,
        //            Description = "the Sunshine state"
        //        });
        //    modelBuilder.Entity<PointOfInterests>().HasData(
        //        new PointOfInterests("ogba-zoo")
        //        {
        //            Id = 1,
        //            CityId = 1,
        //            Description = "A park for different animals"

        //        },
        //          new PointOfInterests("pogba-zoo")
        //          {
        //              Id = 2,
        //              CityId = 1,
        //              Description = "A park for unique animals"
        //          },
        //            new PointOfInterests("Lekki-Shoprite")
        //            {
        //                Id = 3,
        //                CityId = 2,
        //                Description = "A place for shooping all kind of items"
        //            },
        //              new PointOfInterests("Ikoyi-Shoprite")
        //              {
        //                  Id = 4,
        //                  CityId = 2,
        //                  Description = "A place for shooping specific kind of items"
        //              },
        //                new PointOfInterests("Futa-zoo")
        //                {
        //                    Id = 5,
        //                    CityId = 3,
        //                    Description = "A park for different animals"
        //                },
        //                  new PointOfInterests("Akure-Shoprite")
        //                  {
        //                      Id = 4,
        //                      CityId = 3,
        //                      Description = "A place for shooping all kind of items"
        //                  }

        //       );



        //    base.OnModelCreating(modelBuilder);
        //}
        public DbSet<City> cities
        { get; set; }
        public DbSet<PointOfInterests> pointOfInterests { get; set; }
    }
}
