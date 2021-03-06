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
        private readonly IRoomBLL _iRoomBLL;

        public HomeController(ILogger<HomeController> logger ,IUserBBL iUserBBL,IRoomTypeBBL iRoomTypeBBL,IRoomBLL iRoomBLL)
        {
            _logger = logger;
            _iUserBBL = iUserBBL;
            _iRoomTypeBBL = iRoomTypeBBL;
            _iRoomBLL = iRoomBLL;
            // getUserDetail();
            // searchUser();
            // editUser();
            // deleteUser();
            // getAllRoomType();
            // addRoomType();
            // editRoomType();
           //  getAllRoom();
            editRoom() ;

        }

        public void editRoom(){
            RoomVM roomVM = _iRoomBLL.getAll(1,2,"hello")[0];
            roomVM.RoomName = "Room1";
            //edit status time
            roomVM.ListStatusTime[0].StatimTodate = Convert.ToDateTime("01/10/2021");

            //add Status time
             StatusVM statusVM = new StatusVM();
             statusVM.IdStatus =1;
             StatusTimeVM statusTimeVM = new StatusTimeVM();
             //statusTimeVM.IdStatim = 4; //gia su minh sua lai thong tin tk status_time da co trong db
             statusTimeVM.StatimFromdate = DateTime.Now;
             statusTimeVM.StatimTodate = Convert.ToDateTime("12/12/2021");
             statusTimeVM.statusVM = statusVM;
             roomVM.ListStatusTime.Add(statusTimeVM);

            //del sattus time
            // List<int>listdel = new List<int>();
            // listdel.Add(3);
            _iRoomBLL.editRoom(roomVM,null);            


        }
        public void getAllRoom(){
            List<RoomVM>listRoomVM = _iRoomBLL.getAll(1,2,"hello");
            string json=JsonConvert.SerializeObject(listRoomVM,Formatting.Indented);
            Console.WriteLine(json); 
        }
        public void getAllRoomType(){
            List<RoomTypeVM> listVM = _iRoomTypeBBL.getAll();

            string json=JsonConvert.SerializeObject(listVM,Formatting.Indented);
            Console.WriteLine(json); 
        }
        public void editRoomType(){
            RoomTypeVM roomTypeVM = _iRoomTypeBBL.findbyid(1);
            string json=JsonConvert.SerializeObject(roomTypeVM,Formatting.Indented);
            Console.WriteLine(json);
            // roomTypeVM.MapImgUrl[1] = "hello";
            //  roomTypeVM.MapImgUrl.Add(8,"justtest");
            // roomTypeVM.MapImgUrl[7] ="";
            roomTypeVM.MapImgUrl[8]="sasda";
            _iRoomTypeBBL.editRoomType(roomTypeVM);
        }

        public void addRoomType(){
            RoomTypeVM roomTypeVM = new RoomTypeVM();
            roomTypeVM.RotyName = "provipRoom";
            roomTypeVM.RotyCapacity=2;
            roomTypeVM.RotyCurrentprice=100;
            roomTypeVM.RotyDescription="qua tot";
            List<string>imglist = new List<string>();
            imglist.Add("/home/cuong/pro");
            imglist.Add("/home/cuong/vip");
            roomTypeVM.ListImgURL = imglist;
            _iRoomTypeBBL.addRoomType(roomTypeVM);
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
