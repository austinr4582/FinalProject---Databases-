namespace LibrarySystem324.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.btnBookEditor = new System.Windows.Forms.Button();
            this.btnAuthorEditor = new System.Windows.Forms.Button();
            this.btnMemberEdi = new System.Windows.Forms.Button();
            this.btnBorrowing = new System.Windows.Forms.Button();
            this.btnUserEdit = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBookEditor
            // 
            this.btnBookEditor.Location = new System.Drawing.Point(614, 12);
            this.btnBookEditor.Name = "btnBookEditor";
            this.btnBookEditor.Size = new System.Drawing.Size(174, 67);
            this.btnBookEditor.TabIndex = 0;
            this.btnBookEditor.Text = "Books Editor";
            this.btnBookEditor.UseVisualStyleBackColor = true;
            this.btnBookEditor.Click += new System.EventHandler(this.btnBookEditor_Click);
            // 
            // btnAuthorEditor
            // 
            this.btnAuthorEditor.Location = new System.Drawing.Point(614, 101);
            this.btnAuthorEditor.Name = "btnAuthorEditor";
            this.btnAuthorEditor.Size = new System.Drawing.Size(174, 67);
            this.btnAuthorEditor.TabIndex = 1;
            this.btnAuthorEditor.Text = "Authors Editor";
            this.btnAuthorEditor.UseVisualStyleBackColor = true;
            // 
            // btnMemberEdi
            // 
            this.btnMemberEdi.Location = new System.Drawing.Point(614, 190);
            this.btnMemberEdi.Name = "btnMemberEdi";
            this.btnMemberEdi.Size = new System.Drawing.Size(174, 67);
            this.btnMemberEdi.TabIndex = 2;
            this.btnMemberEdi.Text = "Members Editor";
            this.btnMemberEdi.UseVisualStyleBackColor = true;
            // 
            // btnBorrowing
            // 
            this.btnBorrowing.Location = new System.Drawing.Point(614, 279);
            this.btnBorrowing.Name = "btnBorrowing";
            this.btnBorrowing.Size = new System.Drawing.Size(174, 67);
            this.btnBorrowing.TabIndex = 3;
            this.btnBorrowing.Text = "Borrowing";
            this.btnBorrowing.UseVisualStyleBackColor = true;
            // 
            // btnUserEdit
            // 
            this.btnUserEdit.Location = new System.Drawing.Point(614, 368);
            this.btnUserEdit.Name = "btnUserEdit";
            this.btnUserEdit.Size = new System.Drawing.Size(174, 67);
            this.btnUserEdit.TabIndex = 4;
            this.btnUserEdit.Text = "User Editor";
            this.btnUserEdit.UseVisualStyleBackColor = true;
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(12, 101);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(521, 337);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 5;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 78);
            this.label1.TabIndex = 6;
            this.label1.Text = "Downtown Libray";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnUserEdit);
            this.Controls.Add(this.btnBorrowing);
            this.Controls.Add(this.btnMemberEdi);
            this.Controls.Add(this.btnAuthorEditor);
            this.Controls.Add(this.btnBookEditor);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookEditor;
        private System.Windows.Forms.Button btnAuthorEditor;
        private System.Windows.Forms.Button btnMemberEdi;
        private System.Windows.Forms.Button btnBorrowing;
        private System.Windows.Forms.Button btnUserEdit;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label label1;
    }
}