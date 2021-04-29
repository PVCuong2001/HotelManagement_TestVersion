using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement.DAL.Interface
{
    public interface IStatusDAL
    {
        public List<Status> getAll();
    }
}
