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

        public void update(Room room)
        {
            _appDbContext.Rooms.Update(room);
            _appDbContext.SaveChanges();
        }
        public void delete(List<int>listdel){
            List<Room>listRoom = new List<Room>();
            foreach(int i in listdel) listRoom.Add(_appDbContext.Rooms.Find(i));
            _appDbContext.Rooms.RemoveRange(listRoom);
            _appDbContext.SaveChanges();
        }
        public Room findbyid()
        {
            throw new System.NotImplementedException();
        }

        public List<Room> getall(int start, int length ,string orderby)
        {

            var result = _appDbContext.Rooms.Include(x =>x.RoomIdroomtypeNavigation).Include(x =>x.StatusTimes).ThenInclude(y => y.StatimIdstatusNavigation).Skip(start).Take(length).ToList();
            return result;                
        }
    }
}