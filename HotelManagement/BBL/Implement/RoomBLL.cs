using System.Collections.Generic;
using AutoMapper;
using HotelManagement.BBL.Interface;
using HotelManagement.DAL.Interface;
using HotelManagement.DTO;
using HotelManagement.ViewModel;

namespace HotelManagement.BBL.Implement
{
    public class RoomBLL : IRoomBLL
    {
        private IRoomDAL _iRoomDAL;
        private IMapper _iMapper;
        public RoomBLL(IRoomDAL iRoomDAL , IMapper iMapper){
            _iRoomDAL = iRoomDAL;
            _iMapper = iMapper;
        }
        public List<RoomVM> getAll(int pages, int rows, string orderby)
        {
            int start = pages * rows;
            int length = rows;
            List<Room> listRoom = _iRoomDAL.getall(start,length,orderby);
            List<RoomVM>listRoomVM = new List<RoomVM>();
            foreach(Room room in listRoom){
                RoomVM roomVM = _iMapper.Map<RoomVM>(room);
                int id = room.RoomIdroomtypeNavigation.IdRoomtype;
                string roomname = room.RoomIdroomtypeNavigation.RotyName;
                roomVM.MapRoomtype.Add(id,roomname);
                listRoomVM.Add(roomVM);
            }
            return listRoomVM;
        }
    }
}