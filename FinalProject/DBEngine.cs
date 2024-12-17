using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibrarySystem324.Model
{
    internal class DBEngine
    {
        public static string CnnStr = "datasource=localhost;port=3306;username=root;" +
            "database=financedb;password=MyDB2024;";

        public static DataTable GetTable(string SQL)
        {
            //connects the application and data base 
            MySqlConnection Cnn = new MySqlConnection(CnnStr);

            //aplly the querry to the table using the string 
            MySqlCommand Cmd = new MySqlCommand(SQL, Cnn);

            //This will get the data
            MySqlDataAdapter Adp = new MySqlDataAdapter();

            //create the data table 
            DataTable dTable = new DataTable();

            Cnn.Open();

            //Gets the data from the command and put it on the Apd
            Adp.SelectCommand = Cmd;

            //Will fill dTable with the data gotten from the adp 
            Adp.Fill(dTable);

            Cnn.Close();

            return dTable;
        }

        public static void Execute(string SQL)
        {
            MySqlConnection Cnn = new MySqlConnection(CnnStr);
            MySqlCommand Cmd = new MySqlCommand(SQL, Cnn);
            Cnn.Open();
            Cmd.ExecuteNonQuery();
            Cnn.Close();
        }
    }
}
