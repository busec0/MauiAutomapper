using System;
using AutoMapper;

namespace MauiAutomapper.Models
{
    internal class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Parent, ParentDto>().ReverseMap();
            CreateMap<Child, ChildDto>().ReverseMap();
        }
    }
}

