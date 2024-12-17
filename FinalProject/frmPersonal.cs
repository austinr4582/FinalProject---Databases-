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
    public partial class frmPersonal : Form
    {
        private DataTable dt = new DataTable();
        private ReciptPersonal selectedRecipt;
        public frmPersonal()
        {
            InitializeComponent();
        }




        private void showRecipt()
        {
            DataTable aTable = ReciptPersonal.PersonalTableWithBusinessName();
            dataGridView1.DataSource = aTable;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            DataTable dt = DBEngine.GetTable("Select reciptID as ReciptID from Personal");
            showRecipt();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReciptPersonal.serach("Business like '%" + txtSearch.Text.Trim() + "%'");
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
                ReciptPersonal rec = new ReciptPersonal(SelRow);

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
            ReciptPersonal.createNew();
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
