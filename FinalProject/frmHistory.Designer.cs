namespace FinalProject
{
    partial class frmHistory
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtReciptTypeAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReciptType = new System.Windows.Forms.TextBox();
            this.boxReciptType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmountSpent = new System.Windows.Forms.TextBox();
            this.History = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 101;
            this.label8.Text = "Total Spent";
            // 
            // txtReciptTypeAmount
            // 
            this.txtReciptTypeAmount.Location = new System.Drawing.Point(132, 398);
            this.txtReciptTypeAmount.Name = "txtReciptTypeAmount";
            this.txtReciptTypeAmount.Size = new System.Drawing.Size(175, 26);
            this.txtReciptTypeAmount.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 99;
            this.label7.Text = "Recipt Type";
            // 
            // txtReciptType
            // 
            this.txtReciptType.Location = new System.Drawing.Point(132, 293);
            this.txtReciptType.Name = "txtReciptType";
            this.txtReciptType.Size = new System.Drawing.Size(175, 26);
            this.txtReciptType.TabIndex = 98;
            // 
            // boxReciptType
            // 
            this.boxReciptType.FormattingEnabled = true;
            this.boxReciptType.Items.AddRange(new object[] {
            "All",
            "Food",
            "GeneralGoods",
            "LivingExpenses",
            "Personal"});
            this.boxReciptType.Location = new System.Drawing.Point(326, 398);
            this.boxReciptType.Name = "boxReciptType";
            this.boxReciptType.Size = new System.Drawing.Size(170, 28);
            this.boxReciptType.TabIndex = 97;
            this.boxReciptType.SelectedIndexChanged += new System.EventHandler(this.boxReciptType_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 96;
            this.label5.Text = "Amount Spent";
            // 
            // txtAmountSpent
            // 
            this.txtAmountSpent.Location = new System.Drawing.Point(129, 345);
            this.txtAmountSpent.Name = "txtAmountSpent";
            this.txtAmountSpent.Size = new System.Drawing.Size(175, 26);
            this.txtAmountSpent.TabIndex = 95;
            // 
            // History
            // 
            this.History.AutoSize = true;
            this.History.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History.ForeColor = System.Drawing.Color.Blue;
            this.History.Location = new System.Drawing.Point(4, 6);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(307, 42);
            this.History.TabIndex = 94;
            this.History.Text = "History Information";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(641, 393);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 51);
            this.btnDelete.TabIndex = 93;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(460, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(625, 26);
            this.txtSearch.TabIndex = 92;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "Business Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 90;
            this.label4.Text = "Date Bought";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 89;
            this.label3.Text = "Buisness Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 88;
            this.label2.Text = "Business";
            // 
            // BookID
            // 
            this.BookID.AutoSize = true;
            this.BookID.Location = new System.Drawing.Point(21, 95);
            this.BookID.Name = "BookID";
            this.BookID.Size = new System.Drawing.Size(72, 20);
            this.BookID.TabIndex = 87;
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
            this.dataGridView1.Size = new System.Drawing.Size(772, 313);
            this.dataGridView1.TabIndex = 86;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // txtBusiness
            // 
            this.txtBusiness.Location = new System.Drawing.Point(132, 146);
            this.txtBusiness.Name = "txtBusiness";
            this.txtBusiness.Size = new System.Drawing.Size(175, 26);
            this.txtBusiness.TabIndex = 85;
            // 
            // txtBusinessType
            // 
            this.txtBusinessType.Location = new System.Drawing.Point(132, 197);
            this.txtBusinessType.Name = "txtBusinessType";
            this.txtBusinessType.Size = new System.Drawing.Size(175, 26);
            this.txtBusinessType.TabIndex = 84;
            // 
            // txtDateBought
            // 
            this.txtDateBought.Location = new System.Drawing.Point(132, 248);
            this.txtDateBought.Name = "txtDateBought";
            this.txtDateBought.Size = new System.Drawing.Size(175, 26);
            this.txtDateBought.TabIndex = 83;
            // 
            // txtReciptID
            // 
            this.txtReciptID.Location = new System.Drawing.Point(132, 95);
            this.txtReciptID.Name = "txtReciptID";
            this.txtReciptID.ReadOnly = true;
            this.txtReciptID.Size = new System.Drawing.Size(175, 26);
            this.txtReciptID.TabIndex = 82;
            // 
            // frmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtReciptTypeAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtReciptType);
            this.Controls.Add(this.boxReciptType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAmountSpent);
            this.Controls.Add(this.History);
            this.Controls.Add(this.btnDelete);
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
            this.Name = "frmHistory";
            this.Text = "frmHistory";
            this.Load += new System.EventHandler(this.frmHistory_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReciptTypeAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReciptType;
        private System.Windows.Forms.ComboBox boxReciptType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmountSpent;
        private System.Windows.Forms.Label History;
        private System.Windows.Forms.Button btnDelete;
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