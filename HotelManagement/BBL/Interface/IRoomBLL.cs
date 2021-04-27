using System.Collections.Generic;
using HotelManagement.ViewModel;

namespace HotelManagement.BBL.Interface
{
    public interface IRoomBLL
    {
    
        List<RoomVM>getAll(int pages,int rows ,string orderby); 
    }
}