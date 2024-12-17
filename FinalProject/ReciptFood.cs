using LibrarySystem324.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
 
    internal class ReciptFood
    {
        private DataRow _Row;
 
        public ReciptFood(DataRow aRow)
        {
            int ReciptID = (int)aRow["ReciptID"];
            DataTable dt = DBEngine.GetTable("Select * From food where ReciptID=" + ReciptID.ToString());

            _Row = dt.Rows[0];
        }


        public static DataTable serach(string filter)
        {
            DataTable Tbl = new DataTable();
            string SQL = "select * from Food ";
            if (filter.Trim() != "") { SQL += "where " + filter.Trim(); }

            Tbl = DBEngine.GetTable(SQL);

            return Tbl;
        }
        public static DataTable FoodTable()
        {
            return DBEngine.GetTable("select * from Food");
        }
        public static DataTable FoodTableWithBusinessName()
        {
            return DBEngine.GetTable("select b.ReciptID,b.DateBought,b.Business,b.BusinessType,b.AmountSpent From food b order by b.reciptID");

        }
        public static void createNew()
        {
            string SQL = "INSERT INTO Food(Business, BusinessType, DateBought, AmountSpent) VALUES('Business', 'BusinessType', 2024, 12)";
            DBEngine.Execute(SQL);
            SQL = "INSERT INTO needsToBePaid (ReciptFromId,Business, BusinessType, DateBought, AmountSpent, ReciptType) VALUES((select max(ReciptID) from food),'Business', 'BusinessType', 2024, 12, 'Food')";
            DBEngine.Execute(SQL);
            SQL = "INSERT INTO FullHistory (ReciptFromId,Business, BusinessType, DateBought, AmountSpent, ReciptType) VALUES((select max(ReciptID) from food),'Business', 'BusinessType', 2024, 12, 'Food')";
            DBEngine.Execute(SQL);
            
        }
        
        public void save()
        {

            string SQL = "UPDATE food SET business='" + Business + "', businessType='" + BusinessType + "', datebought=" + DateBought.ToString() + ", AmountSpent=" + AmountSpent.ToString() + " WHERE ReciptID=" + ReciptID.ToString();
            DBEngine.Execute(SQL);
            SQL = "UPDATE needsToBePaid SET ReciptFromID='" + ReciptID + "', business='" + Business + "', businessType='" + BusinessType + "', datebought=" + DateBought.ToString() + ", AmountSpent=" + AmountSpent.ToString() + " WHERE ReciptFromID=" + ReciptID.ToString() + " and ReciptType = 'Food'";
            DBEngine.Execute(SQL);
            SQL = "UPDATE fullhistory SET ReciptFromID='" + ReciptID + "', business='" + Business + "', businessType='" + BusinessType + "', datebought=" + DateBought.ToString() + ", AmountSpent=" + AmountSpent.ToString() + " WHERE ReciptFromID=" + ReciptID.ToString() +" and ReciptType = 'Food'";
            DBEngine.Execute(SQL);

        }

        public void delete()
        {

            string sqldel = "SELECT * FROM food Where reciptId=" + ReciptID.ToString();
            DataTable dt = DBEngine.GetTable(sqldel);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("You cannot delete this recipt!");
            }
            else
            {
                string SQL = "DELETE FROM food WHERE reciptID=" + ReciptID.ToString();
                DBEngine.Execute(SQL);
            }

        }

        public int ReciptID => (int)_Row["ReciptID"];
        public double AmountSpent
        {
            get
            {
                return (double)_Row["AmountSpent"];
            }
            set
            {
                _Row["AmountSpent"] = value;
            }
        }
        public int DateBought
        {
            get
            {
                return (int)_Row["DateBought"];
            }
            set
            {
                _Row["DateBought"] = value;
            }
        }
        public string Business
        {
            get
            {
                return (string)_Row["Business"];
            }
            set
            {
                _Row["Business"] = value;
            }
        }
        public string BusinessType
        {
            get
            {
                return (string)_Row["BusinessType"];
            }
            set
            {
                _Row["BusinessType"] = value;
            }
        }

        public string ReciptType
        {
            get
            {
                return (string)_Row["ReciptType"];
            }
            set
            {
                _Row["ReciptType"] = value;
            }
        }






    }
}
