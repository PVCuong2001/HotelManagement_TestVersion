using System;
using System.Collections.Generic;
using AutoMapper;
using HotelManagement.BBL.Interface;
using HotelManagement.DAL.Interface;
using HotelManagement.DTO;
using HotelManagement.ViewModel;

namespace HotelManagement.BBL.Implement
{
    public class RoomTypeBBL : IRoomTypeBBL
    {
        private IRoomtypeDAL _iRoomTypeDAL;
        private readonly IMapper _iMapper;
        public RoomTypeBBL(IMapper iMapper, IRoomtypeDAL iRoomTypeDAL){
            _iRoomTypeDAL = iRoomTypeDAL;
            _iMapper = iMapper;
        }

        public List<RoomTypeVM> getAll()
        {
            var result = _iRoomTypeDAL.getAll();
            Console.WriteLine(result[0].ImgStorages.Count); 
            List<RoomTypeVM> listVM =new List<RoomTypeVM>();
            foreach(RoomType roomType in _iRoomTypeDAL.getAll()){
                RoomTypeVM roomTypeVM = _iMapper.Map<RoomTypeVM>(roomType);
                foreach(ImgStorage imgStorage in roomType.ImgStorages){
                    roomTypeVM.ListImgURL.Add(imgStorage.ImgstoUrl);
                }
                listVM.Add(roomTypeVM);
            }
            return listVM;
        }

        public void addRoomType(RoomTypeVM roomTypeVM)
        {
            throw new System.NotImplementedException();
        }

        public void editRoomType(RoomTypeVM roomTypeVM)
        {
            throw new System.NotImplementedException();
        }

        public void deleteRoomType(int idRoomType)
        {
            throw new System.NotImplementedException();
        }
    }
}