namespace LibraryManagementSystem
{
    partial class bookStorage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookStorage));
            this.lbbookStoragewd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbbookStorage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbbookStoragewd
            // 
            this.lbbookStoragewd.BackColor = System.Drawing.Color.BlueViolet;
            this.lbbookStoragewd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbbookStoragewd.Location = new System.Drawing.Point(0, 0);
            this.lbbookStoragewd.Name = "lbbookStoragewd";
            this.lbbookStoragewd.Size = new System.Drawing.Size(960, 55);
            this.lbbookStoragewd.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.BlueViolet;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbbookStorage
            // 
            this.lbbookStorage.AutoSize = true;
            this.lbbookStorage.BackColor = System.Drawing.Color.BlueViolet;
            this.lbbookStorage.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbbookStorage.ForeColor = System.Drawing.Color.White;
            this.lbbookStorage.Location = new System.Drawing.Point(65, 14);
            this.lbbookStorage.Name = "lbbookStorage";
            this.lbbookStorage.Size = new System.Drawing.Size(143, 27);
            this.lbbookStorage.TabIndex = 2;
            this.lbbookStorage.Text = "Book Storage";
            // 
            // bookStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.Controls.Add(this.lbbookStorage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbbookStoragewd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bookStorage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Storage";
            this.Load += new System.EventHandler(this.bookStorage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbbookStoragewd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbbookStorage;
    }
}