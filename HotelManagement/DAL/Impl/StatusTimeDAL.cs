using System;
using System.Collections.Generic;
using System.Linq;
using HotelManagement.DAL.Interface;
using HotelManagement.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

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

        public void edit(List<StatusTime>listedit){
        //   var transaction = _appDbContext.Database.UseTransaction(_appDbContext.transaction.GetDbTransaction());
            try{
                _appDbContext.StatusTimes.UpdateRange(listedit);
                _appDbContext.SaveChanges();
                _appDbContext.transaction.Commit();
            }catch(Exception e){
                _appDbContext.transaction.RollbackToSavepoint("Before update StatusTime");
            }
        }
    }
}