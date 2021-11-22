using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>()
                .ForMember(c => c.Id,
                    opt => opt.Ignore());
            
            Mapper.CreateMap<Movie, MovieDto>()
                .ForMember(m => m.Id,
                    opt => opt.Ignore());

            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            //    .ForMember(t => t.Id,
            //        opt => opt.Ignore());

            // Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<MovieDto, Movie>();
            //Mapper.CreateMap<MembershipTypeDto, MembershipType>();





        }
    }
}