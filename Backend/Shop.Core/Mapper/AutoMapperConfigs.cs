using AutoMapper;
using Shop.Core.DTOs.User;
using Shop.Entity.Entities;

namespace Shop.Core.Mapper
{
    public class AutoMapperConfigs : Profile
    {
        public AutoMapperConfigs()
        {
            CreateMap<SignupDto, User>();
        }
    }
}
