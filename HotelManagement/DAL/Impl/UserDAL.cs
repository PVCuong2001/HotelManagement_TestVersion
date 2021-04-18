using System;
using System.Linq;
using HotelManagement.Extention;
using HotelManagement.DAL.Interface;
using HotelManagement.DTO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using HotelManagement.ViewModel;

namespace HotelManagement.DAL
{
    public class UserDAL :IUserDAL
    {
        private AppDbContext _appDbContext ;     
        public UserDAL(AppDbContext appDbContext){
            _appDbContext = appDbContext ;
        }
        public User findbyid(int id_user){
            var user = _appDbContext.Users.Where(x => x.IdUser ==id_user).Include(x => x.UserRoles).ThenInclude(y =>y.UserolIdroleNavigation).ThenInclude(z =>z.Auths).ThenInclude(t =>t.AuthIdmenuNavigation).SingleOrDefault();
            return user;
        }

        public List<User> findbyproperty(string name, string code )
        {
            // string clause = "x."+property+"==";
            var predicate = PredicateBuilder.True<User>();
            if(!string.IsNullOrEmpty(code)) predicate = predicate.And(x =>x.UserCode ==code);
            
            if(!string.IsNullOrEmpty(name))  predicate = predicate.And(x =>x.UserName == name);
            
            List<User> userlist = _appDbContext.Users.Where(predicate)
                                   .Include(x => x.UserRoles)
                                   .ThenInclude(y =>y.UserolIdroleNavigation)
                                   .ThenInclude(z =>z.Auths)
                                   .ThenInclude(t =>t.AuthIdmenuNavigation).ToList();
            return userlist;
        }

        public void addUser(UserVM userVM){
            
        }
    }
}