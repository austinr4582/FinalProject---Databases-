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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            frmFood frm = new frmFood();
            frm.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLivingExpense frm = new frmLivingExpense();
            frm.ShowDialog(this);

        }

        private void btnGenGood_Click(object sender, EventArgs e)
        {
            frmGenGoods frm = new frmGenGoods();
            frm.ShowDialog(this);
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            frmPersonal frm = new frmPersonal();
            frm.ShowDialog(this);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            frmNeedPay frm = new frmNeedPay();
            frm.ShowDialog(this);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            frmHistory frm = new frmHistory();
            frm.ShowDialog(this);
        }
    }
}
