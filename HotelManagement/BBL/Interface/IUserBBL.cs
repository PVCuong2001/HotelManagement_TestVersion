using System.Collections.Generic;
using HotelManagement.ViewModel;

namespace HotelManagement.BBL
{
    public interface IUserBBL
    {
         UserVM getUserByID(int id);
         List<UserVM> searchUser(string name ,string code);
         void addUser(UserVM userVM);
         void editUser(UserVM userVM);
         void deleteUser(int idUser);
    }
}