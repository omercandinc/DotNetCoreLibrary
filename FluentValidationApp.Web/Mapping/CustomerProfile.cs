using AutoMapper;
using FluentValidationApp.Web.DTOs;
using FluentValidationApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationApp.Web.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(dest => dest.Isim, options => options.MapFrom(x => x.Name))
                .ForMember(dest => dest.Eposta, options => options.MapFrom(x => x.Email))
                .ForMember(dest => dest.Yas, options => options.MapFrom(x => x.Age))
                .ForMember(dest => dest.FullName, options => options.MapFrom(x => x.FullName2()));

        }
    }
}
