using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public static class STATIC
    {
        public static string stringConnectionDatabase = "";
        public static string tutorialFile = "";  // System.Windows.Forms.Application.StartupPath + @"\Information\Tutorial.pdf";

        public static string[] arrayTableDB = new string[100];// { "person", "city", "country", "employeesname" };  

        /// <summary>
        /// Array with all tables name in Database
        /// </summary>
        /// <param name="tables"></param>       
        public static void SetTablesArray(string tables)
        {
            arrayTableDB = tables.Split(',');
        }

    }
   


    public static class CONST
    {
        //*******************************************************************************
        //  Software verioning
        public const string versionSW = "0.0.0.1";


        //*******************************************************************************
        //  List of Database in localHost
        public const string DATABASE_NAME = "hoteldatabase";


        //*******************************************************************************
        //  Connection MySql.Data.MySqlClient
        public const string NAME_SERVER = "127.0.0.1"; //localHost
        public const string NAME_USER = "localhost";
        public const string PASSWORD = "";  // = String.Empty; //Per il mio database, non ho selezionato alcuna password, ma la variabile la rendiamo statica
        public const int PORT = 3306;


        //*******************************************************************************
        //  Query Database SQL
        public const string readAllTableDB = "SHOW TABLES";
        public const string readTableDB = "SELECT * FROM ";
        public const string findRefFromDB = "SELECT * FROM {0} WHERE {1}=";
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
        public const string titleReferenceRoom = "REFERENCE ROOM SELECTED";
        public const string ERROR = "ERROR EXCEPTION";
        public const string modifyDBCompetMSG = "QUERY OF DATABASE COMPETED!";
        public const string newElement = "NEW ELEMENT";
        

        //    MessageBox Questions information
        public const string deleteQuestionMSG = "DELETE ELEMENT?";
        public const string sureQuestionMSG = "ARE YOU SHURE?";
        public const string saveQuestionMSG = "SAVE INFORMATION?";


    }
}
