using AutoMapper;
using Gladiatus.Application.Dtos;
using Gladiatus.Core.Entities;

namespace Gladiatus.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateUserDto, ApplicationUser>();
            CreateMap<ApplicationUser, CreateUserDto>();
        }
    }
}