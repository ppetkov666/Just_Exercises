using AutoMapper;
using Car_Rental_Project.Data;
using Car_Rental_Project.Dto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car_Rental_Project.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Car, CarDto>();
            Mapper.CreateMap<CarDto, Car>();

        }
    }
}