using System.Collections.Generic;
using HotelManagement.DTO;

namespace HotelManagement.DAL.Interface
{
    public interface IRoomtypeDAL
    {
        List<RoomType> getAll();
        void Add(RoomType roomType);
    }
}