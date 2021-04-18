using AutoMapper;
using HotelManagement.DTO;

namespace HotelManagement.ViewModel
{
    public class MappingProfile : Profile
    {
   public MappingProfile(){ 
            
            CreateMap<User,UserVM>().ReverseMap();
            CreateMap<Role,RoleVM>().ReverseMap();
            CreateMap<Menu,MenuVM>().ReverseMap();
            // .ForMember(dest =>dest.IdRoomtype ,opt =>opt.MapFrom(src => src.ImgroomImgstoNavigation.ImgroomImgstoNavigation.IdRoomtype) ) 
        
        }   
    }
}