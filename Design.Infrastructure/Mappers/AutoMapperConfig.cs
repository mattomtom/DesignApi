using AutoMapper;
using Design.Core.Domain;
using Design.Infrastructure.DTO;

namespace Design.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize() => 
            new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDto>();
                cfg.CreateMap<Walker, WalkerDto>();  
            })
            .CreateMapper();
    }
}