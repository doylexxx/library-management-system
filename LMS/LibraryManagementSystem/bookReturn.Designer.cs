namespace LibraryManagementSystem
{
    partial class bookReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookReturn));
            this.lbbookreturnwd = new System.Windows.Forms.Label();
            this.lbbookReturn = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // lbbookreturnwd
            // 
            this.lbbookreturnwd.BackColor = System.Drawing.Color.BlueViolet;
            this.lbbookreturnwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbbookreturnwd.Location = new System.Drawing.Point(0, 0);
            this.lbbookreturnwd.Name = "lbbookreturnwd";
            this.lbbookreturnwd.Size = new System.Drawing.Size(960, 55);
            this.lbbookreturnwd.TabIndex = 0;
            // 
            // lbbookReturn
            // 
            this.lbbookReturn.AutoSize = true;
            this.lbbookReturn.BackColor = System.Drawing.Color.BlueViolet;
            this.lbbookReturn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbbookReturn.ForeColor = System.Drawing.Color.White;
            this.lbbookReturn.Location = new System.Drawing.Point(65, 14);
            this.lbbookReturn.Name = "lbbookReturn";
            this.lbbookReturn.Size = new System.Drawing.Size(131, 27);
            this.lbbookReturn.TabIndex = 1;
            this.lbbookReturn.Text = "Book Return";
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
            // bookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.lbbookReturn);
            this.Controls.Add(this.lbbookreturnwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bookReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bookReturn";
            this.Load += new System.EventHandler(this.bookReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbbookreturnwd;
        private System.Windows.Forms.Label lbbookReturn;
        private System.Windows.Forms.PictureBox buttonReturn;
    }
}