using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whakahaere_z1
{

    /// <summary>
    /// Enum describe status Hotel's room (single room)
    /// </summary>
    public enum STATUSROOM
    {
        AVAILABLE,
        BUSY,
        REPAIR,
        RESTRUCTURATION
    }

    /// <summary>
    /// Enum of restaurant
    /// </summary>
    public enum SERVICERESTAURANT
    {
        ANTIPASTI,
        PRIMI,
        RISOTTI,
        PESCI,       
        CARNI,        
        DESSER
    }

    /// <summary>
    /// Enum of service of Hotel (what can you find in room or in hotel)
    /// </summary>
    public enum SERVICEHOTEL
    { 
        BATHROOM,
        GENERAL_SERVICE,
        ROOM,
        FREE_SPACE,
        KITCHEN,
        ACCESSIBILITY,
        BAR_RESTAURANT,
        MEDIA_TV,
        INTERNET,
        PARKING,
        CLEANING_ROOM,       
        WELLNESS,
        HOSPITALITY,
        SNACK_DRINK,
        ENTERTAINMENT,
        BUSINESS,
        SECURITY,
        LANGUAGES
    }

    /// <summary>
    /// Tipi di accesso disponibili, ogniuno con funzioni diverse
    /// </summary>
    public enum ACCESSEMPLOYEES
    { 
        RECEPTION, //Accesso limitato (visualizza alcune informazioni)
        MANAGER, //Accesso completo (ma non tutto modificabile)
        ADMINISTRATION,//Accesso completo e modificabile
        MASTERUSER//Accesso completo, modificabile e cancellabile
    }


    public class ValueConstant
    {
        //*******************************************************************************
        //    Array of tables
        public string[] arrTable = new string[100];// { "person", "person2", "person3", "person4", "city", "country", "employeesname" };       

        public void SetTablesArray(string tables)
        {
            arrTable = tables.Split(',');
        }
    }

    public static class CONSTANT
    {
        //*******************************************************************************
        //    list of files available in this software
        public static string tutorialFile = System.Windows.Forms.Application.StartupPath + @"\Information\Tutorial.pdf";

        //*******************************************************************************
        //    Connection string for connecting with database 
        public static string stringConnection = ""; //Viene inizializzata all'avvio del Form dedicato


        //*******************************************************************************
        //    Versioning for this software
        public const string VERSION_SW = "1.0.0";

        //*******************************************************************************
        //    Connection MySql.Data.MySqlClient
        public const string NAME_SERVER = "127.0.0.1"; //localHost
        public const string NAME_USER = "localhost";
        public const string PASSWORD = "";  // = String.Empty; //Per il mio database, non ho selezionato alcuna password, ma la variabile la rendiamo statica
        public const int PORT = 3306;

        //*******************************************************************************
        //    list of Database in localHost
        public const string DATABASE_NAME = "hoteldatabase";

        //*******************************************************************************
        //   Query connection for Database MariaDB
        public const string readAllTableDB = "SHOW TABLES";
        public const string readTableDB = "SELECT * FROM ";
        public const string findRefCountryDB = "SELECT * FROM {0} WHERE {}=";
        public const string orderDescDB = "SELECT * FROM {0} ORDER BY {1} DESC";
        public const string valuesDB = " VALUES ";
        public const string insertDB = "INSERT INTO ";
        public const string updateDB = "UPDATE ";
        public const string setDB = " SET ";
        public const string whereDB = " WHERE ";
        public const string IdDB = "ID";
        public const string deleteDB = "DELETE FROM ";

        //*******************************************************************************
        //    MessageBox text and information
        public const string DIRECTORY = "DIRECTORY";
        public const string FILENOTFOUND = "FILE NOT FOUND";
        public const string CONNECTIONOK = "CONNECTION OPEN";
        public const string titleReferenceMSG = "REFERENCE OBJECT";
        public const string ERROR = "ERROR EXCEPTION";
        public const string modifyDBCompetMSG = "QUERY OF DATABASE COMPETED!";
        public const string newElement = "NEW ELEMENT";

        //    MessageBox Questions information
        public const string deleteQuestionMSG = "DELETE ELEMENT?";
        public const string sureQuestionMSG = "ARE YOU SHURE?";
        public const string saveQuestionMSG = "SAVE INFORMATION?";
    }
}
