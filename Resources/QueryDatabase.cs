using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Resources
{
    public class QueryDatabase
    {
        /// <summary>
        /// Restituiamo tutte le tabelle presenti nel database 
        /// </summary>
        /// <param name="stringConnection"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        public string ReadAllTablesMariaDB(string stringConnection, string query)
        {
            string row = "";
            MySqlConnection connection = new MySqlConnection(stringConnection);
            MySqlCommand command = new MySqlCommand(query, connection);
            // command.CommandText = query;
            MySqlDataReader Reader;
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    row += Reader.GetValue(i).ToString() + ",";
                    Console.WriteLine(Reader.GetValue(i).ToString() + ",");
                }
            }
            connection.Close();

            return row;
        }



        /// <summary>
        /// Restituiamo tutti gli elementi (items) presenti nella tabella
        /// </summary>
        /// <param name="stringConnection"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable GetValues(string stringConnection, string query)
        {
            DataTable dTable = new DataTable();
            try
            {
                MySqlConnection sqlConnection = new MySqlConnection(stringConnection);
                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);

                sqlConnection.Open();

                MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(sqlCommand);
                // this will query your database and return the result to your datatable
                sqlAdapter.Fill(dTable);

                {/*
                Console.WriteLine("***************************************");
                foreach (DataColumn col in dTable.Columns)
                {
                    Console.WriteLine("Column:{0} Type:{1}", col.ColumnName, col.DataType);
                }
                Console.WriteLine("***************************************");
                */
                }

                sqlConnection.Close();
                sqlAdapter.Dispose();

                return dTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    
    
       
        
    }
}
