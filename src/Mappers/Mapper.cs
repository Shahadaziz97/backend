

using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Stock, StockCreatDto>();
            CreateMap<StockCreatDto, Stock>();


            CreateMap<Product, PoductReadDTO>();
            CreateMap<PoductReadDTO, Product>();
        }
    }
}