using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whakahaere
{
    public class Prenotation
    {
        int iD;

        int iDBedroom;
        Bedroom bedroom = new Bedroom();

        int iDClient;
        Client client = new Client();

        double totalPayment;
        double advancePayment;

        DateTime dateStart;
        DateTime dateEnd;

        public int ID { get => iD; set => iD = value; } //Auto Increment
        public int IDBedroom { get => iDBedroom; set => iDBedroom = value; }
        public Bedroom Bedroom { get => bedroom; set => bedroom = value; } //Oggetto Bedroom
        public int IDClient { get => iDClient; set => iDClient = value; }
        public Client Client { get => client; set => client = value; } //Oggetto Client
        public double TotalPayment { get => totalPayment; set => totalPayment = value; }
        public double AdvancePayment { get => advancePayment; set => advancePayment = value; }
        public DateTime DateStart { get => dateStart; set => dateStart = value; }
        public DateTime DateEnd { get => dateEnd; set => dateEnd = value; }
    }
}
