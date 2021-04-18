using System.Collections.Generic;

namespace HotelManagement.ViewModel
{
    public class RoleVM
    {
        
        public int IdRole { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public List<MenuVM> menuVMlist {get; set;}
    }
}