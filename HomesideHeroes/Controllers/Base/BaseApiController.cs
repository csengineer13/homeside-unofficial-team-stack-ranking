
using System.Web.Http;
using AutoMapper;
using HomesideHeroes.Viewmodels.AutoMapper.Homeside.ViewModel;

namespace HomesideHeroes.Controllers.Base
{
    public class BaseApiController : ApiController
    {
        protected static IMapper Mapper;

        public BaseApiController()
        {
            Mapper = AutoMapperConfig.MapperConfiguration.CreateMapper();
        }
    }
}