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

        public static string[] arrTable = new string[100];// { "person", "person2", "person3", "person4", "city", "country", "employeesname" };  

        /// <summary>
        /// Carichiamo l'array con tutti i nomi delle tabelle
        /// </summary>
        /// <param name="tables"></param>       
        public static void SetTablesArray(string tables)
        {
            arrTable = tables.Split(',');
        }

    }
   
    public class CONSTVALUE
    {
        //*******************************************************************************
        //    Software verioning
        public const string versionSW = "0.1.0";

    }

    public class CONST_DATABASE
    {
        //*******************************************************************************
        //    list of Database in localHost
        public const string DATABASE_NAME = "hoteldatabase";

        //*******************************************************************************
        //    Connection MySql.Data.MySqlClient
        public const string NAME_SERVER = "127.0.0.1"; //localHost
        public const string NAME_USER = "localhost";
        public const string PASSWORD = "";  // = String.Empty; //Per il mio database, non ho selezionato alcuna password, ma la variabile la rendiamo statica
        public const int PORT = 3306;


        //*******************************************************************************
        //    
        public const string readAllTableDB = "SHOW TABLES";
        public const string readTableDB = "SELECT * FROM ";
    }

    public class VALUE
    {

    }
}
