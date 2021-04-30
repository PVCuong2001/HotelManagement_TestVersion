using System.Collections.Generic;
using System.Linq;
using HotelManagement.DAL.Interface;
using HotelManagement.DTO;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Impl
{
    public class StatusTimeDAL : IStatusTImeDAL
    {
            private AppDbContext _appDbContext;
            public StatusTimeDAL(AppDbContext appDbContext){
                _appDbContext = appDbContext;
            }
        public void delete(List<int> listdel)
        {
            List<StatusTime>list = new List<StatusTime>();
            foreach(int id in listdel){
                StatusTime statusTime = _appDbContext.StatusTimes.Find(id);
                _appDbContext.Entry(statusTime).State = EntityState.Detached;
                if(statusTime !=null) list.Add(statusTime);
            }
            _appDbContext.RemoveRange(list);
            _appDbContext.SaveChanges();
        }
    }
}