using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whakahaere
{
    public class Payments
    {
        int iD;
        string metods;

        string details;
        DataTable dtailsTable = new DataTable();

        public int ID { get => iD; set => iD = value; }
        public string Metods { get => metods; set => metods = value; }
        public string Details { get => details; set => details = value; } //Serializzazione dei dettagli di pagamento
        public DataTable DetailsTable { get => dtailsTable; set => dtailsTable = value; } //Tabella con i dettagli del pagamento
    }
}
