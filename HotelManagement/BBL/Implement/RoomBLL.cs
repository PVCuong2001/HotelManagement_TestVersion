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

        public void editRoom(RoomVM roomVM)
        {
            Room room = new Room();
            _iMapper.Map(roomVM,room);
            List<int>listdel = new List<int>();
            foreach(StatusTimeVM statusTimeVM in roomVM.ListStatusTime){
                if(statusTimeVM.check==-1) listdel.Add(statusTimeVM.IdStatim);
                StatusTime statusTime = new StatusTime();
                _iMapper.Map(statusTimeVM , statusTime);
                statusTime.IdStatim = statusTimeVM.statusVM.IdStatus;
                room.StatusTimes.Add(statusTime);
            }
            _iRoomDAL.update(room);
            _iRoomDAL.delete(listdel);
        }

        // public void editRoomType(RoomTypeVM roomTypeVM)
        // {
        //     RoomType roomType = new RoomType();
        //     _iMapper.Map(roomTypeVM,roomType);
        //     List<int> img_del = new List<int>();
        //     foreach(KeyValuePair<int, string> kvp in roomTypeVM.MapImgUrl){
        //         if(kvp.Value ==""){
        //             img_del.Add(kvp.Key);
        //         }else{
        //         ImgStorage imgStorage = new ImgStorage();
        //         if(kvp.Key>0) imgStorage.IdImgsto = kvp.Key;

        //             imgStorage.ImgstoIdrootyp = roomTypeVM.IdRoomtype;
        //             imgStorage.ImgstoUrl = kvp.Value;
        //             roomType.ImgStorages.Add(imgStorage);
        //         } 

        //     }
        //     foreach(int val in img_del){
        //         _iImgStorageDAL.delete(val);
        //     }
        //     _iRoomTypeDAL.updateRoomtype(roomType);
        // }

        public List<RoomVM> getAll(int pages, int rows, string orderby)
        {
            int start = (pages-1) * rows;
            int length = rows;
            List<Room> listRoom = _iRoomDAL.getall(start, length, orderby);
            List<RoomVM> listRoomVM = new List<RoomVM>();
            foreach (Room room in listRoom)
            {
                RoomVM roomVM = _iMapper.Map<RoomVM>(room);
                int id = room.RoomIdroomtypeNavigation.IdRoomtype;
                string roomname = room.RoomIdroomtypeNavigation.RotyName;
                roomVM.MapRoomtype.Add(id, roomname);
                foreach(StatusTime statusTime in room.StatusTimes)
                {
                    StatusTimeVM statusTimeVM = _iMapper.Map<StatusTimeVM>(statusTime);
                    statusTimeVM.statusVM = _iMapper.Map<StatusVM>(statusTime.StatimIdstatusNavigation);
                    statusTimeVM.check=1;
                    roomVM.ListStatusTime.Add(statusTimeVM);
                }
                listRoomVM.Add(roomVM);
            }
            return listRoomVM;
        }
    }
}