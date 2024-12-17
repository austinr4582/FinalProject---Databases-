using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem324.Model
{
    internal class Book
    {
        private DataRow _Row;
        public Book(DataRow aRow)
        {
            int bookID = (int)aRow["bookID"];
            DataTable dt = DBEngine.GetTable("Select * From book where bookID=" + bookID.ToString());

            _Row = dt.Rows[0];
        }


        public static DataTable serach(string filter)
        {
            DataTable Tbl = new DataTable();
            string SQL = "select * from Book ";
            if (filter.Trim() != "") { SQL += "where " + filter.Trim(); }

            Tbl = DBEngine.GetTable(SQL);

            return Tbl;
        }
        public static DataTable booksTable()
        {
            return DBEngine.GetTable("select * from Book");
        }
        public static DataTable booksTableWithAuthorName()
        {
            return DBEngine.GetTable("select b.BookID,b.Title,b.ISBN,b.PublishedYear,CONCAT(a.firstName,'  ' ,a.lastName) as authorName From book b join Author a On a.authorID=b.authorID order by b.bookID");

        }
        public static void createNew()
        {
            string SQL = "INSERT INTO Book(Title, ISBN, PublishedYear, AuthorID) VALUES('new Book', '', 1900, 1)";
            DBEngine.Execute(SQL);
        }

        public void save()
        {

            string SQL = "UPDATE Book SET Title='" + Title + "', ISBN='" + ISBN + "', PublishedYear=" + PublishedYear.ToString() + ", AuthorID=" + AuthorID.ToString() + " WHERE BookID=" + bookID.ToString();
            DBEngine.Execute(SQL);

        }

        public void delete()
        {

            string sqldel = "SELECT * FROM borrow Where bookId=" + bookID.ToString();
            DataTable dt = DBEngine.GetTable(sqldel);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("You cannot delete this book!");
            }
            else
            {
                string SQL = "DELETE FROM Book WHERE BookID=" + bookID.ToString();
                DBEngine.Execute(SQL);
            }

        }

        public int bookID => (int)_Row["bookID"];
        public string Title
        {
            get
            {
                return (string)_Row["Title"];
            }
            set
            {
                _Row["Title"] = value;
            }
        }
        public string ISBN
        {
            get
            {
                return (string)_Row["ISBN"];
            }
            set
            {
                _Row["ISBN"] = value;
            }
        }
        public int PublishedYear
        {
            get
            {
                return (int)_Row["PublishedYear"];
            }
            set
            {
                _Row["PublishedYear"] = value;
            }
        }
        public int AuthorID
        {
            get
            {
                return (int)_Row["AuthorID"];
            }
            set
            {
                _Row["AuthorID"] = value;
            }
        }




    }
}