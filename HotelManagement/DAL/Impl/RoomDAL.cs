using System.Collections.Generic;
using System.Linq;
using HotelManagement.DAL.Interface;
using HotelManagement.DTO;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Impl
{
    public class RoomDAL : IRoomDAL
    {
        private AppDbContext _appDbContext;
        public RoomDAL(AppDbContext appDbContext){
            _appDbContext = appDbContext;
        }
        public Room findbyid()
        {
            throw new System.NotImplementedException();
        }

        public List<Room> getall(int page, int rows ,string orderby)
        {

            var result = _appDbContext.Rooms.Include(x =>x.RoomIdroomtypeNavigation).Skip(rows*page).Take(rows).ToList();
            return result;                
        }
    }
}