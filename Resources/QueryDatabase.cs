using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Resources
{
    /// <summary>
    /// 
    /// </summary>
    public class QueryDatabase
    {
        /// <summary>
        /// Return all tables in database
        /// </summary>
        /// <param name="stringConnection"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        public string ReadAllTablesDB(string stringConnection, string query)
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
        /// Return Datatable with all items in database.table
        /// </summary>
        /// <param name="stringConnection"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable GetTableItems(string stringConnection, string query)
        {
            DataTable dTable = new DataTable();
            try
            {
                MySqlConnection sqlConnection = new MySqlConnection(stringConnection);
                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);

                sqlConnection.Open();

                MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dTable);

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
