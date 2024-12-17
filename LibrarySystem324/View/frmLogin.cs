using Org.BouncyCastle.Crypto.Engines;
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

namespace LibrarySystem324.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            bool ok = true;

            DataTable dt = DBEngine.GetTable("Select * from user where upper(Email) ='" + txtLoginID.Text.ToUpper()
                +
                "' and userPassword = '" + txtPassword.Text + "'");

            ok = dt.Rows.Count > 0;
            if (ok)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }//end of form class 
}
