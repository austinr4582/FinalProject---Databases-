using LibrarySystem324.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmHistory : Form
    {
        private DataTable dt = new DataTable();
        private ReciptHistory selectedRecipt;
        public frmHistory()
        {
            InitializeComponent();
        }
        private void showRecipt()
        {
            DataTable aTable = ReciptHistory.HistoryTableWithBusinessName();
            dataGridView1.DataSource = aTable;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView Grd = dataGridView1;
                DataTable Tbl = (DataTable)Grd.DataSource;
                DataRow SelRow = Tbl.Rows[e.RowIndex];
                ReciptHistory rec = new ReciptHistory(SelRow);

                txtReciptID.Text = rec.ReciptID.ToString();
                txtBusiness.Text = rec.Business;
                txtAmountSpent.Text = rec.AmountSpent.ToString();
                txtBusinessType.Text = rec.BusinessType;
                txtDateBought.Text = rec.DateBought.ToString();
                txtReciptType.Text = rec.ReciptType;

                selectedRecipt = rec;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete Recipt with " +
                " business (" + selectedRecipt.AmountSpent + ")", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                selectedRecipt.delete();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do somthing else
            }
            showRecipt();
        }

        private void boxReciptType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SQL;

            if (boxReciptType.Text == "All")
            {
                SQL = "select sum(AmountSpent) from FullHistory";
            }
        }

        private void frmHistory_Load_1(object sender, EventArgs e)
        {
            DataTable aTable = ReciptFull.FullTableWithBusinessName();
            dataGridView1.DataSource = aTable;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReciptFull.serach("Business like '%" + txtSearch.Text.Trim() + "%'");

        }

        private void boxReciptType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string SQL;

            if (boxReciptType.Text == "All")
            {
                SQL = "select sum(AmountSpent) as FullAmount from FullHistory";
                DataTable dt = DBEngine.GetTable(SQL);
                txtReciptTypeAmount.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                SQL = "select sum(AmountSpent) as FullAmount from FullHistory where ReciptType = '" + boxReciptType.Text + "'";
                dt = DBEngine.GetTable(SQL);
                //The value we are getting from the statement is one one row and one column at 0, 0
                txtReciptTypeAmount.Text = dt.Rows[0][0].ToString();
            }
        }
    }
}
