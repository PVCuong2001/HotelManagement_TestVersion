using System;
using System.Collections.Generic;
using System.Linq;
using HotelManagement.DAL.Interface;
using HotelManagement.DTO;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace HotelManagement.DAL.Impl
{
    public class RoomtypeDAL : IRoomtypeDAL
    {
        private AppDbContext _appDbContext;
        public RoomtypeDAL(AppDbContext appDbContext){
            _appDbContext = appDbContext;
        }
        public void Add(RoomType roomType)
        {
            _appDbContext.RoomTypes.Add(roomType);
            _appDbContext.SaveChanges();   
        }

        public List<RoomType> getAll()
        {
            var result = _appDbContext.RoomTypes.Include(x => x.ImgStorages).ToList();
            return result;
        }
    }
}