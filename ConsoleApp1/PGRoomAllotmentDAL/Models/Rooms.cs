using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGRoomAllotmentDAL.Models
{
    public class Rooms
    {
        public int roomNo { get; set; }
        public string name { get; set; }
        public string contactNo { get; set; }
        public string homeCity { get; set; }
        public string homeState { get; set; }
        public double rent { get; set; }
        public double deposite { get; set; }
        public string companyName { get; set; }
    }
}
