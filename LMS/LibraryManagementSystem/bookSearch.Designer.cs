namespace LibraryManagementSystem
{
    partial class bookSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookSearch));
            this.lbbookSearchwd = new System.Windows.Forms.Label();
            this.buttonreturn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buttonreturn)).BeginInit();
            this.SuspendLayout();
            // 
            // lbbookSearchwd
            // 
            this.lbbookSearchwd.BackColor = System.Drawing.Color.BlueViolet;
            this.lbbookSearchwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbbookSearchwd.Location = new System.Drawing.Point(0, 0);
            this.lbbookSearchwd.Name = "lbbookSearchwd";
            this.lbbookSearchwd.Size = new System.Drawing.Size(960, 55);
            this.lbbookSearchwd.TabIndex = 0;
            // 
            // buttonreturn
            // 
            this.buttonreturn.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonreturn.Image = ((System.Drawing.Image)(resources.GetObject("buttonreturn.Image")));
            this.buttonreturn.Location = new System.Drawing.Point(20, 13);
            this.buttonreturn.Name = "buttonreturn";
            this.buttonreturn.Size = new System.Drawing.Size(30, 30);
            this.buttonreturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonreturn.TabIndex = 1;
            this.buttonreturn.TabStop = false;
            this.buttonreturn.Click += new System.EventHandler(this.buttonreturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BlueViolet;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Search";
            // 
            // bookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonreturn);
            this.Controls.Add(this.lbbookSearchwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bookSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.bookSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonreturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbbookSearchwd;
        private System.Windows.Forms.PictureBox buttonreturn;
        private System.Windows.Forms.Label label1;
    }
}