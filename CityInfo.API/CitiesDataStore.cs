using CityInfo.API.Model;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<citiesDtos> Cities { get; set; }
        public static CitiesDataStore current { get; } = new CitiesDataStore();
        public CitiesDataStore()
        {
            Cities = new List<citiesDtos>()
            {
                new citiesDtos()
                {

            Id = 1,
            Name = "Benin city",
            Description="the heartbeat of the nation",
            PointOfInterests=new List<PointOfInterestDto>()
            {
                new PointOfInterestDto
                {
                    Id=1,
                    Name="ogba-zoo",
                    Description="A park for different animals"

                },
                        new PointOfInterestDto
                {
                    Id=2,
                    Name="pogba-zoo",
                    Description="A park for unique animals"

                }
            }


        },
                 new citiesDtos()
                 {

                         Id = 2,
                         Name = "Lagos",
                         Description = "A land of true hustlers",
                         PointOfInterests=new List<PointOfInterestDto>()
            {
                      new PointOfInterestDto
                    {
                             Id=3,
                             Name="Lekki-Shoprite",
                             Description="A place for shooping all kind of items"

                     },
                    new PointOfInterestDto
                {
                             Id=4,
                             Name="Ikoyi-Shoprite",
                             Description="A place for shooping specific kind of items"

                }
            }

            },
            new citiesDtos()
            {

                     Id = 3,
                     Name = "Akure",
                     Description = "the Sunshine state",
                     PointOfInterests=new List<PointOfInterestDto>()
            {
                new PointOfInterestDto
                {
                    Id=5,
                    Name="Futa-zoo",
                    Description="A park for different animals"

                },
                        new PointOfInterestDto
                {
                    Id=4,
                    Name="Akure-Shoprite",
                    Description="A place for shooping all kind of items"

                }
            }
                                    },
            };


        }

    }
}
