using System.Collections.Generic;

namespace HotelManagement.ViewModel
{
    public class RoomTypeVM
    {
        
        public int IdRoomtype { get; set; }
        public string RotyName { get; set; }
        public string RotyDescription { get; set; }
        public decimal RotyCurrentprice { get; set; }
        public int RotyCapacity { get; set; }
        public List<string>ListImgURL { get; set;}
    }
}