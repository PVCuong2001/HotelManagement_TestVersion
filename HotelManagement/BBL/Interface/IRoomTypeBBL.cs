using System.Collections.Generic;
using HotelManagement.ViewModel;

namespace HotelManagement.BBL.Interface
{
    public interface IRoomTypeBBL
    {
         List<RoomTypeVM>getAll();
         void addRoomType(RoomTypeVM roomTypeVM);
         void editRoomType(RoomTypeVM roomTypeVM);
         void deleteRoomType(int idRoomType);
         RoomTypeVM findbyid(int id);
    }
}