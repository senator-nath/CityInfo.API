﻿namespace CityInfo.API.Model
{
    public class citiesDtos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int NumberOfPointOfInterest
        {
            get
            {
                return PointOfInterests.Count;
            }
        }

        public ICollection<PointOfInterestDto> PointOfInterests { get; set; } = new List<PointOfInterestDto>();
    }
}
