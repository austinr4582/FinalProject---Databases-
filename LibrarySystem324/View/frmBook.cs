using LibrarySystem324.Model;
using Org.BouncyCastle.Crypto.Modes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem324.View
{
    public partial class frmBook : Form
   
    {
        private DataTable dt = new DataTable();
        private Book selectedBook;
        public frmBook()
        {
            InitializeComponent();
        }


        private void bynAddNew_Click(object sender, EventArgs e)
        {
            Book.createNew();
            showBook();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete Book with " +
                " title (" + selectedBook.Title + ")", "Delete", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                selectedBook.delete();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do somthing else
            }
            showBook(); 
        }
        private void showBook()
        {
            DataTable aTable = Book.booksTableWithAuthorName();
            dataGridView1.DataSource = aTable;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            DataTable dt = DBEngine.GetTable("Select authorID, CONCAT(firstname, ' ', lastname) as authorName from author");
            drpAuthor.DataSource = dt;
            drpAuthor.DisplayMember = "authorName";
            drpAuthor.ValueMember = "authorID";
            showBook();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Book.serach("Title like '%" + txtSearch.Text.Trim() + "%'");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView Grd = dataGridView1;
                DataTable Tbl = (DataTable)Grd.DataSource;
                DataRow SelRow = Tbl.Rows[e.RowIndex];
                Book bok = new Book(SelRow);

                txtBookID.Text = bok.bookID.ToString();
                txtTitle.Text = bok.Title;
                txtISBN.Text = bok.ISBN.ToString();
                txtPubYear.Text = bok.PublishedYear.ToString();
                drpAuthor.SelectedValue = bok.AuthorID;

                selectedBook = bok; 
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            selectedBook.Title = txtTitle.Text;
            selectedBook.ISBN = txtISBN.Text;
            selectedBook.PublishedYear = Int32.Parse(txtPubYear.Text);
            selectedBook.AuthorID = Int32.Parse(drpAuthor.SelectedValue.ToString());

            selectedBook.save();
            showBook();

        }
    }
}
