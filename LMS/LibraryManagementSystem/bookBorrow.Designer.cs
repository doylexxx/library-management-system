namespace LibraryManagementSystem
{
    partial class bookBorrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookBorrow));
            this.lbbookBorrowwd = new System.Windows.Forms.Label();
            this.lbbookBorrow = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // lbbookBorrowwd
            // 
            this.lbbookBorrowwd.BackColor = System.Drawing.Color.BlueViolet;
            this.lbbookBorrowwd.Location = new System.Drawing.Point(0, 0);
            this.lbbookBorrowwd.Name = "lbbookBorrowwd";
            this.lbbookBorrowwd.Size = new System.Drawing.Size(960, 55);
            this.lbbookBorrowwd.TabIndex = 0;
            // 
            // lbbookBorrow
            // 
            this.lbbookBorrow.AutoSize = true;
            this.lbbookBorrow.BackColor = System.Drawing.Color.BlueViolet;
            this.lbbookBorrow.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbbookBorrow.ForeColor = System.Drawing.Color.White;
            this.lbbookBorrow.Location = new System.Drawing.Point(65, 14);
            this.lbbookBorrow.Name = "lbbookBorrow";
            this.lbbookBorrow.Size = new System.Drawing.Size(139, 27);
            this.lbbookBorrow.TabIndex = 1;
            this.lbbookBorrow.Text = "Book Borrow";
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonReturn.Image = ((System.Drawing.Image)(resources.GetObject("buttonReturn.Image")));
            this.buttonReturn.Location = new System.Drawing.Point(20, 13);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(30, 30);
            this.buttonReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.TabStop = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // bookBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.lbbookBorrow);
            this.Controls.Add(this.lbbookBorrowwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bookBorrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bookBorrow";
            this.Load += new System.EventHandler(this.bookBorrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbbookBorrowwd;
        private System.Windows.Forms.Label lbbookBorrow;
        private System.Windows.Forms.PictureBox buttonReturn;
    }
}