using System.Collections.Generic;
using HotelManagement.DTO;

namespace HotelManagement.DAL.Interface
{
    public interface IRoomtypeDAL
    {
        List<RoomType> getAll();
        void addRoomtype(RoomType roomType);
        void updateRoomtype(RoomType roomType);
        void deleteRoomtype(int idRoomtype);
        RoomType findbyid(int id);
        int getnextid();
    }
}