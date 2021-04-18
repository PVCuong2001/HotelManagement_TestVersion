using System;
using System.Collections.Generic;
using AutoMapper;
using HotelManagement.DAL.Interface;
using HotelManagement.DTO;
using HotelManagement.ViewModel;
using Newtonsoft.Json;

namespace HotelManagement.BBL
{
    public class UserBBL : IUserBBL
    {
        private readonly IUserDAL _iUserDAL;
        private readonly IMapper _iMapper;
        public UserBBL(IUserDAL iUserDAL,IMapper iMapper){
            _iUserDAL = iUserDAL;
            _iMapper = iMapper;
        }

        public UserVM getUserByID(int id)
        {
            List<RoleVM> roleVMlist = new List<RoleVM>();
            var user = _iUserDAL.findbyid(1);
            UserVM userVM =_iMapper.Map<UserVM>(user);
            foreach(UserRole userRole in user.UserRoles){
                if(userRole.UserolActiveflag==1){
                    Role role = userRole.UserolIdroleNavigation;
                    RoleVM roleVM = _iMapper.Map<RoleVM>(role);
                    roleVMlist.Add(roleVM);
                }
            }
            userVM.roleVMlist=roleVMlist;
            return userVM;
        }

        public List<UserVM> searchUser(string name ,string code)
        {
            List<RoleVM> roleVMlist ;
            List<UserVM>userVMlist = new List<UserVM>();
            List<MenuVM>menuVMlist ;
            var userlist = _iUserDAL.findbyproperty(name,code);
            foreach(User user in userlist){
                UserVM userVM =_iMapper.Map<UserVM>(user);
                roleVMlist = new List<RoleVM>();
                foreach(UserRole userRole in user.UserRoles){
                    if(userRole.UserolActiveflag==1){
                        Role role = userRole.UserolIdroleNavigation;
                        RoleVM roleVM = _iMapper.Map<RoleVM>(role);
                        menuVMlist = new List<MenuVM>();
                        foreach(Auth auth in userRole.UserolIdroleNavigation.Auths){
                            Menu menu = auth.AuthIdmenuNavigation;
                            MenuVM menuVM = _iMapper.Map<MenuVM>(menu);
                            menuVMlist.Add(menuVM);
                        }
                        roleVM.menuVMlist = menuVMlist;
                        roleVMlist.Add(roleVM);
                    }
                }
                userVM.roleVMlist=roleVMlist;
                userVMlist.Add(userVM);
            }
            return userVMlist;

        }

        public void addUser(UserVM userVM){
            User user =new User();
            _iMapper.Map(userVM,user);
            string json=JsonConvert.SerializeObject(user,Formatting.Indented);
            Console.WriteLine(json); 
        }
    }
}