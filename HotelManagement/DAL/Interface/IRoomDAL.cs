using System.Collections.Generic;
using HotelManagement.DTO;

namespace HotelManagement.DAL.Interface
{
    public interface IRoomDAL
    {
         List<Room>getall(int page ,int rows ,string orderby);
         Room findbyid();
         void update(Room room);
         void delete(List<int>listdel);
    }
}