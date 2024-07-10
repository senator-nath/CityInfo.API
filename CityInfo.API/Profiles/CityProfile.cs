﻿using AutoMapper;
using CityInfo.API.Entities;
using CityInfo.API.Model;

namespace CityInfo.API.Profiles
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<City, CitiesWithoutPointOfInterestDto>();
        }
    }
}
