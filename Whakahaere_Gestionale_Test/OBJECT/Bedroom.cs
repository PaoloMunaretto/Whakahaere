using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whakahaere
{
    public class Bedroom
    {
        int iD;
        byte floor;
        byte room;
        byte bed;
        byte bathroom;
        double cost;
        string status;
        string notes;

        int iDHotelRoom;
        HotelInformation hotelRoom = new HotelInformation();

        public int ID { get => iD; set => iD = value; }
        public byte Floor { get => floor; set => floor = value; }
        public byte Room { get => room; set => room = value; }
        public byte Bed { get => bed; set => bed = value; }
        public byte Bathroom { get => bathroom; set => bathroom = value; }
        public double Cost { get => cost; set => cost = value; }
        public string Status { get => status; set => status = value; }
        public string Notes { get => notes; set => notes = value; }
        public int IDHotelRoom { get => iDHotelRoom; set => iDHotelRoom = value; }
        public HotelInformation HotelRoom { get => hotelRoom; set => hotelRoom = value; }       
    }

    public class BedroomMetods
    {
        /// <summary>
        /// Convertiamo la riga della tabella(Bedroom) in oggetto type Bedroom
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public Bedroom ConvertRowToObject(DataRow row)
        {
            Bedroom room = new Bedroom();

            room.ID = Int32.Parse(row.ItemArray[0].ToString());
            room.Floor = Convert.ToByte(row.ItemArray[1].ToString());
            room.Room = Convert.ToByte(row.ItemArray[2].ToString());
            room.Bed = Convert.ToByte(row.ItemArray[3].ToString());
            room.Bathroom = Convert.ToByte(row.ItemArray[4].ToString());
            room.Cost = Double.Parse(row.ItemArray[5].ToString());
            room.Status = row.ItemArray[6].ToString();

            room.Notes = row.ItemArray[7].ToString(); //Deve diventare una JSON dataTable

            room.IDHotelRoom = Int32.Parse(row.ItemArray[8].ToString());
            //room.HotelRoom = Bedroom.findFromID(room.IDHotelRoom);

            return room;
        }
    }
}
