using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HotelManagement.Models;
using HotelManagement.DTO;
using HotelManagement.DAL.Interface;
using HotelManagement.BBL;
using HotelManagement.ViewModel;
using Newtonsoft.Json;
using HotelManagement.BBL.Interface;

namespace HotelManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserBBL _iUserBBL;
        private readonly IRoomTypeBBL _iRoomTypeBBL;

        public HomeController(ILogger<HomeController> logger ,IUserBBL iUserBBL,IRoomTypeBBL iRoomTypeBBL)
        {
            _logger = logger;
            _iUserBBL = iUserBBL;
            _iRoomTypeBBL = iRoomTypeBBL;
            // getUserDetail();
            // searchUser();
            // editUser();
            // deleteUser();
            getAllRoomType();
        }


        public void getAllRoomType(){
            List<RoomTypeVM> listVM = _iRoomTypeBBL.getAll();

            string json=JsonConvert.SerializeObject(listVM,Formatting.Indented);
            Console.WriteLine(json); 
        }

        public void getUserDetail(){
            UserVM userVM =_iUserBBL.getUserByID(1);
            string json=JsonConvert.SerializeObject(userVM,Formatting.Indented);
            Console.WriteLine(json); 
        }

        public void searchUser(){
            List<UserVM> userVMlist =_iUserBBL.searchUser("cuong","");
            string json=JsonConvert.SerializeObject(userVMlist,Formatting.Indented);
            Console.WriteLine(json); 
        }
        public void addUser(){
            UserVM userVM = new UserVM();
            userVM.UserName="vippro";
            userVM.UserCode="CCCC";
            userVM.UserGender=true;
            userVM.UserGmail="@gmail.com";
            userVM.UserPhone="09213";
            userVM.UserPhoto=1;
            userVM.UserActiveflag=true;

            RoleVM roleVM = new RoleVM();
            roleVM.IdRole=3;
            RoleVM roleVM1 = new RoleVM();
            roleVM1.IdRole =2;

            List<RoleVM>roleVMs = new List<RoleVM>();
            roleVMs.Add(roleVM);
            roleVMs.Add(roleVM1);

            userVM.roleVMlist = roleVMs;            
            _iUserBBL.addUser(userVM);
        }

        public void editUser(){
            UserVM userVM = _iUserBBL.getUserByID(1);
            userVM.roleVMlist[0].IdRole=4;
            userVM.roleVMlist[0].UserRoleActiveFlag=false;
            _iUserBBL.editUser(userVM);
        }
        public void deleteUser(){
            _iUserBBL.deleteUser(3);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
