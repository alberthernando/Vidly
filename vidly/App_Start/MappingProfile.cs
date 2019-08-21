using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using vidly.Models;
using vidly.Dtos;

namespace vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MovieDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore());

            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();

            Mapper.CreateMap<Rental, RentalDto>();
            Mapper.CreateMap<RentalDto, Rental>().ForMember(r => r.Id, opt => opt.Ignore());
        }
    }
}