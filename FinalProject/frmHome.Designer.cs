namespace FinalProject
{
    partial class frmHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnLiving = new System.Windows.Forms.Button();
            this.btnGenGood = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Page";
            // 
            // btnFood
            // 
            this.btnFood.Location = new System.Drawing.Point(583, 13);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(145, 61);
            this.btnFood.TabIndex = 1;
            this.btnFood.Text = "Food";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnLiving
            // 
            this.btnLiving.Location = new System.Drawing.Point(583, 84);
            this.btnLiving.Name = "btnLiving";
            this.btnLiving.Size = new System.Drawing.Size(145, 61);
            this.btnLiving.TabIndex = 2;
            this.btnLiving.Text = "Living Expenses ";
            this.btnLiving.UseVisualStyleBackColor = true;
            this.btnLiving.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGenGood
            // 
            this.btnGenGood.Location = new System.Drawing.Point(583, 155);
            this.btnGenGood.Name = "btnGenGood";
            this.btnGenGood.Size = new System.Drawing.Size(145, 61);
            this.btnGenGood.TabIndex = 3;
            this.btnGenGood.Text = "General Goods";
            this.btnGenGood.UseVisualStyleBackColor = true;
            this.btnGenGood.Click += new System.EventHandler(this.btnGenGood_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.Location = new System.Drawing.Point(583, 226);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(145, 61);
            this.btnPersonal.TabIndex = 4;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(583, 297);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(145, 61);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Needs To Be Paid";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(583, 368);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(145, 61);
            this.btnHistory.TabIndex = 6;
            this.btnHistory.Text = "Full History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.money1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 336);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnPersonal);
            this.Controls.Add(this.btnGenGood);
            this.Controls.Add(this.btnLiving);
            this.Controls.Add(this.btnFood);
            this.Controls.Add(this.label1);
            this.Name = "frmHome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnLiving;
        private System.Windows.Forms.Button btnGenGood;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

