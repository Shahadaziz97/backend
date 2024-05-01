using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
namespace sda_onsite_2_csharp_backend_teamwork.src.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile(){
            CreateMap<User, UserReadDto>();
            CreateMap<UserReadDto, User>();
        }
    }
}