using AutoMapper;
using HomesideHeroes.Models;

namespace HomesideHeroes.Viewmodels.AutoMapper.Profiles
{
    public class PluralsightUsersProfile : Profile
    {
        public PluralsightUsersProfile()
        {
            CreateMap<PluralsightUsers, PluralsightUsersDto>()
                //.ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email)) // first, last, ...
                ;
        }

    }
}