using System;
using System.Collections.Generic;
using System.Linq;
using HotelManagement.DAL.Interface;
using HotelManagement.DTO;
using HotelManagement.Extention;
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
            try{
                bool tracking= _appDbContext.ChangeTracker.Entries<Room>().Any(x => x.Entity.IdRoom == room.IdRoom);
                if(tracking) throw new InvalidOperationException("Error while updating room");
                // foreach(StatusTime statusTime in room.StatusTimes){
                //     _appDbContext.Entry(statusTime.StatimIdstatusNavigation).State = EntityState.Detached;
                // }
                    _appDbContext.Rooms.Update(room);
                    _appDbContext.SaveChanges();
            }catch(Exception e){
                throw ;
            }
        }
        public void delete(List<int>listdel){
            List<Room>listRoom = new List<Room>();
            foreach(int i in listdel) {
                Room room=_appDbContext.Rooms.Find(i);
                if(room !=null) listRoom.Add(room);
            }
            try{
            _appDbContext.Rooms.RemoveRange(listRoom);
            _appDbContext.SaveChanges();
            }catch(Exception e){
                throw ;
            }
        }
        public Room findbyid(int id)
        {
            return _appDbContext.Rooms.Find(id);
        }

        public List<Room> getall(int start, int length ,string orderby)
        {

            var result = _appDbContext.Rooms.Include(x =>x.RoomIdroomtypeNavigation)
                                            .Include(x =>x.StatusTimes)
                                            .ThenInclude(y => y.StatimIdstatusNavigation)
                                            .Skip(start).Take(length)
                                            .AsNoTracking()
                                            .ToList();
            return result;                
        }

       
    }
}