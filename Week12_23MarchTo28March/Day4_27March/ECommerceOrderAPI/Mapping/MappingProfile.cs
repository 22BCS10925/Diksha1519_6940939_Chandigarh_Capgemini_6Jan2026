using AutoMapper;
using ECommerceOrderAPI.DTOs;
using ECommerceOrderAPI.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ECommerceOrderAPI.Mapping
{
 

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<OrderDto, Order>();
        }
    }
}
