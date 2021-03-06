using System.Collections.Generic;
using HotelManagement.DTO;

namespace HotelManagement.DAL.Interface
{
    public interface IUserDAL
    {
         User findbyid(int id_user);
         List<User> findbyproperty(string name, string code );
         void addUser(User user);
         void editUser(User user);
         void deleteUser(int idUser);
         int getnextid();
    }
}