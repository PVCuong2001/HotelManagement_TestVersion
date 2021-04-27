using System.Collections.Generic;

namespace HotelManagement.ViewModel
{
    public class RoomVM
    {
        public RoomVM(){
            MapRoomtype = new Dictionary<int,string>();
        }
        public int IdRoom { get; set; }
        public string RoomName { get; set; }
        public string RoomDescription { get; set; }

        public IDictionary<int,string>MapRoomtype{get; set;}
    }
}