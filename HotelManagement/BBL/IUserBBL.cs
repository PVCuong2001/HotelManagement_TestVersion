using System.Collections.Generic;
using HotelManagement.ViewModel;

namespace HotelManagement.BBL
{
    public interface IUserBBL
    {
         UserVM getUserByID(int id);
         List<UserVM> searchUser(string name ,string code);
    }
}