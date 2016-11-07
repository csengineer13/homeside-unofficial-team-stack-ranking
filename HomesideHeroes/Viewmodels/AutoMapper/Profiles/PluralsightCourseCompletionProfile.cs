using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using HomesideHeroes.Models;
using HomesideHeroes.Models.Utils;

namespace HomesideHeroes.Viewmodels.AutoMapper.Profiles
{
    public class PluralsightCourseCompletionProfile : Profile
    {
        public PluralsightCourseCompletionProfile()
        {
            CreateMap<PluralsightCourseCompletion, CourseCompletionRecentlyCompleted>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName))
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.FirstViewDate))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.CompletionDate))
                .ForMember(dest => dest.DaysToComplete, opt => opt.MapFrom(src => (DateTime.Parse(src.CompletionDate) - DateTime.Parse(src.FirstViewDate)).Days))
                ;
        }
    }
}