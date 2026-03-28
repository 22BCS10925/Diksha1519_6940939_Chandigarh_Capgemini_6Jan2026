using AutoMapper;
using E_CommerceApi.DTO;
using E_CommerceApi.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace E_CommerceApi.Maping
{
 

    public class MapingProfile : Profile
    {
        public MapingProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<RegisterDTO, User>();
        }
    }

}
