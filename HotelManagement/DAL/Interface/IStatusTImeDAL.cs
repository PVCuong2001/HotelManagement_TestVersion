using System.Collections.Generic;
using HotelManagement.DTO;

namespace HotelManagement.DAL.Interface
{
    public interface IStatusTImeDAL
    {
         void delete(List<int>listdel);
          void edit(List<StatusTime>listedit);
    }
}