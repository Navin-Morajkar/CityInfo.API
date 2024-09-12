﻿using AutoMapper;

namespace CityInfo.API.Profiles
{
    public class PointOfIntrestProfile : Profile
    {
        public PointOfIntrestProfile() 
        {
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestDto>();
        }
    }
}
