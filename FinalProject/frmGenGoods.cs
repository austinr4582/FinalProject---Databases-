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
    public partial class frmGenGoods : Form
    {
        private DataTable dt = new DataTable();
        private ReciptGenGoods selectedRecipt;
        public frmGenGoods()
        {
            InitializeComponent();
        }

        private void showRecipt()
        {
            DataTable aTable = ReciptGenGoods.GenGoodsTableWithBusinessName();
            dataGridView1.DataSource = aTable;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void frmGenGoods_Load_1(object sender, EventArgs e)
        {
            DataTable dt = DBEngine.GetTable("Select reciptID as ReciptID from GeneralGoods");
            showRecipt();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReciptGenGoods.serach("Business like '%" + txtSearch.Text.Trim() + "%'");

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView Grd = dataGridView1;
                DataTable Tbl = (DataTable)Grd.DataSource;
                DataRow SelRow = Tbl.Rows[e.RowIndex];
                ReciptGenGoods rec = new ReciptGenGoods(SelRow);

                txtReciptID.Text = rec.ReciptID.ToString();
                txtBusiness.Text = rec.Business;
                txtAmountSpent.Text = rec.AmountSpent.ToString();
                txtBusinessType.Text = rec.BusinessType;
                txtDateBought.Text = rec.DateBought.ToString();

                selectedRecipt = rec;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bynAddNew_Click(object sender, EventArgs e)
        {
            ReciptGenGoods.createNew();
            showRecipt();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            selectedRecipt.AmountSpent = Double.Parse(txtAmountSpent.Text);
            selectedRecipt.Business = txtBusiness.Text;
            selectedRecipt.DateBought = Int32.Parse(txtDateBought.Text);
            selectedRecipt.BusinessType = txtBusinessType.Text;

            selectedRecipt.save();
            showRecipt();
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
    }
}
