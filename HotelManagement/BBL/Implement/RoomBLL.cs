using System;
using System.Collections.Generic;
using System.Linq;
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
        private IStatusTImeDAL _iStatusTimeDAL;
        public RoomBLL(IRoomDAL iRoomDAL , IMapper iMapper , IStatusTImeDAL iStatusTimeDAL){
            _iRoomDAL = iRoomDAL;
            _iMapper = iMapper;
            _iStatusTimeDAL = iStatusTimeDAL;
        }

        public void editRoom(RoomVM roomVM , List<int>listdel)
        {
            Room room = new Room();
            _iMapper.Map(roomVM,room);
            room.RoomIdroomtype = roomVM.MapRoomtype.First().Key;
            foreach(StatusTimeVM statusTimeVM in roomVM.ListStatusTime){
                StatusTime statusTime = new StatusTime();
                _iMapper.Map(statusTimeVM , statusTime);
                // Status status = new Status();
                // _iMapper.Map(statusTimeVM.statusVM,status);
                // statusTime.StatimIdstatusNavigation = status;
                statusTime.StatimIdstatus = statusTimeVM.statusVM.IdStatus;
                statusTime.StatimIdroom = room.IdRoom;
                room.StatusTimes.Add(statusTime);
            }
            try{
                _iRoomDAL.update(room);
                if(listdel.Count !=0) _iStatusTimeDAL.delete(listdel);
            }catch(Exception e){
                Console.WriteLine(e.Message);
            }
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