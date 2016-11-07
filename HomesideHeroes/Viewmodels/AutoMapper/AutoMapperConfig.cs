using AutoMapper;
using HomesideHeroes.Viewmodels.AutoMapper.Profiles;

namespace HomesideHeroes.Viewmodels.AutoMapper
{
    namespace Homeside.ViewModel
    {
        // Read more here:
        // https://github.com/AutoMapper/AutoMapper/wiki

        // Note: not as straightforward when going from DTO -> Domain:
        // http://www.devtrends.co.uk/blog/stop-using-automapper-in-your-data-access-code

        public static class AutoMapperConfig
        {
            public static MapperConfiguration MapperConfiguration;

            public static void RegisterMappings()
            {
                MapperConfiguration = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile(new PluralsightCourseCompletionProfile());
                    cfg.AddProfile(new PluralsightCourseUsageProfile());
                    cfg.AddProfile(new PluralsightUsersProfile());
                });
            }
        }
    }
}