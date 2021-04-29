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
            CreateMap<RoomType,RoomTypeVM>().ReverseMap();
            CreateMap<Room,RoomVM>().ReverseMap();
            CreateMap<Status,StatusVM>().ReverseMap();
            CreateMap<StatusTime,StatusTimeVM>().ReverseMap();
            // .ForMember(dest =>dest.IdRoomtype ,opt =>opt.MapFrom(src => src.ImgroomImgstoNavigation.ImgroomImgstoNavigation.IdRoomtype) ) 
        
        }   
    }
}