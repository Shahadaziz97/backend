

using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;

namespace sda_onsite_2_csharp_backend_teamwork.src.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Product , PoductReadDTO>();
            CreateMap<PoductReadDTO ,Product >();
        }
    }
}