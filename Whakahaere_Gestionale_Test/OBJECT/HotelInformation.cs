using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whakahaere
{
    public class HotelInformation
    {
        int iD;
        string hotelName;
        string hotelStreet;

        public int ID { get => iD; set => iD = value; }
        public string HotelName { get => hotelName; set => hotelName = value; }
        public string HotelStreet { get => hotelStreet; set => hotelStreet = value; }
          
    }
}
