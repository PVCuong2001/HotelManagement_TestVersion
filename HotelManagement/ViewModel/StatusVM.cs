using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement.ViewModel
{
    public class StatusVM
    {
        public StatusVM(){}
        public StatusVM(int id , string name){
            IdStatus = id;
            StaName = name;
        }
        public int IdStatus { get; set; }
        public string StaName { get; set; }
    }
}
