namespace FinalProject
{
    partial class frmLivingExpense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmountSpent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.bynAddNew = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BookID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBusiness = new System.Windows.Forms.TextBox();
            this.txtBusinessType = new System.Windows.Forms.TextBox();
            this.txtDateBought = new System.Windows.Forms.TextBox();
            this.txtReciptID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 76;
            this.label5.Text = "Amount Spent";
            // 
            // txtAmountSpent
            // 
            this.txtAmountSpent.Location = new System.Drawing.Point(132, 302);
            this.txtAmountSpent.Name = "txtAmountSpent";
            this.txtAmountSpent.Size = new System.Drawing.Size(175, 26);
            this.txtAmountSpent.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(9, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 27);
            this.label6.TabIndex = 74;
            this.label6.Text = "Living Expenses Information";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(641, 393);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 51);
            this.btnDelete.TabIndex = 73;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(365, 393);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 51);
            this.btnSave.TabIndex = 72;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bynAddNew
            // 
            this.bynAddNew.Location = new System.Drawing.Point(89, 393);
            this.bynAddNew.Name = "bynAddNew";
            this.bynAddNew.Size = new System.Drawing.Size(150, 51);
            this.bynAddNew.TabIndex = 71;
            this.bynAddNew.Text = "Add New";
            this.bynAddNew.UseVisualStyleBackColor = true;
            this.bynAddNew.Click += new System.EventHandler(this.bynAddNew_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(460, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(607, 26);
            this.txtSearch.TabIndex = 70;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Business Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "Date Bought";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Buisness Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Business";
            // 
            // BookID
            // 
            this.BookID.AutoSize = true;
            this.BookID.Location = new System.Drawing.Point(21, 95);
            this.BookID.Name = "BookID";
            this.BookID.Size = new System.Drawing.Size(72, 20);
            this.BookID.TabIndex = 65;
            this.BookID.Text = "ReciptID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(313, 55);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(754, 313);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter_1);
            // 
            // txtBusiness
            // 
            this.txtBusiness.Location = new System.Drawing.Point(132, 146);
            this.txtBusiness.Name = "txtBusiness";
            this.txtBusiness.Size = new System.Drawing.Size(175, 26);
            this.txtBusiness.TabIndex = 63;
            // 
            // txtBusinessType
            // 
            this.txtBusinessType.Location = new System.Drawing.Point(132, 197);
            this.txtBusinessType.Name = "txtBusinessType";
            this.txtBusinessType.Size = new System.Drawing.Size(175, 26);
            this.txtBusinessType.TabIndex = 62;
            // 
            // txtDateBought
            // 
            this.txtDateBought.Location = new System.Drawing.Point(132, 248);
            this.txtDateBought.Name = "txtDateBought";
            this.txtDateBought.Size = new System.Drawing.Size(175, 26);
            this.txtDateBought.TabIndex = 61;
            // 
            // txtReciptID
            // 
            this.txtReciptID.Location = new System.Drawing.Point(132, 95);
            this.txtReciptID.Name = "txtReciptID";
            this.txtReciptID.ReadOnly = true;
            this.txtReciptID.Size = new System.Drawing.Size(175, 26);
            this.txtReciptID.TabIndex = 60;
            // 
            // frmLivingExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAmountSpent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.bynAddNew);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BookID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBusiness);
            this.Controls.Add(this.txtBusinessType);
            this.Controls.Add(this.txtDateBought);
            this.Controls.Add(this.txtReciptID);
            this.Name = "frmLivingExpense";
            this.Text = "frmLivingExpense";
            this.Load += new System.EventHandler(this.frmLivingExpense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmountSpent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button bynAddNew;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BookID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBusiness;
        private System.Windows.Forms.TextBox txtBusinessType;
        private System.Windows.Forms.TextBox txtDateBought;
        private System.Windows.Forms.TextBox txtReciptID;
    }
}