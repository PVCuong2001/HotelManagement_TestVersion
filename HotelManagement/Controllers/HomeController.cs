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

namespace HotelManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserBBL _iUserBBL;

        public HomeController(ILogger<HomeController> logger ,IUserBBL iUserBBL)
        {
            _logger = logger;
            _iUserBBL = iUserBBL;
            // getUserDetail();
            searchUser();
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
