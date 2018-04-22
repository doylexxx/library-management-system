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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonReturnBook = new System.Windows.Forms.Button();
            this.listbook = new System.Windows.Forms.ListView();
            this.bno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.press = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbid = new System.Windows.Forms.Label();
            this.textCno = new System.Windows.Forms.TextBox();
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
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSearch.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSearch.Location = new System.Drawing.Point(167, 417);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(160, 60);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonReturnBook
            // 
            this.buttonReturnBook.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonReturnBook.FlatAppearance.BorderSize = 0;
            this.buttonReturnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.buttonReturnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturnBook.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonReturnBook.ForeColor = System.Drawing.Color.Transparent;
            this.buttonReturnBook.Location = new System.Drawing.Point(538, 417);
            this.buttonReturnBook.Name = "buttonReturnBook";
            this.buttonReturnBook.Size = new System.Drawing.Size(160, 60);
            this.buttonReturnBook.TabIndex = 10;
            this.buttonReturnBook.Text = "return";
            this.buttonReturnBook.UseVisualStyleBackColor = false;
            // 
            // listbook
            // 
            this.listbook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bno,
            this.category,
            this.title,
            this.press,
            this.year,
            this.author,
            this.price,
            this.total,
            this.stock});
            this.listbook.Location = new System.Drawing.Point(70, 156);
            this.listbook.Name = "listbook";
            this.listbook.Size = new System.Drawing.Size(800, 173);
            this.listbook.TabIndex = 11;
            this.listbook.UseCompatibleStateImageBehavior = false;
            this.listbook.View = System.Windows.Forms.View.Details;
            // 
            // bno
            // 
            this.bno.Text = "bno";
            // 
            // category
            // 
            this.category.Text = "category";
            this.category.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.category.Width = 100;
            // 
            // title
            // 
            this.title.Text = "title";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.title.Width = 150;
            // 
            // press
            // 
            this.press.Text = "press";
            this.press.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.press.Width = 100;
            // 
            // year
            // 
            this.year.Text = "year";
            this.year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.year.Width = 100;
            // 
            // author
            // 
            this.author.Text = "author";
            this.author.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.author.Width = 100;
            // 
            // price
            // 
            this.price.Text = "price";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total
            // 
            this.total.Text = "total";
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stock
            // 
            this.stock.Text = "stock";
            this.stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbid.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbid.Location = new System.Drawing.Point(66, 348);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(62, 20);
            this.lbid.TabIndex = 12;
            this.lbid.Text = "Card ID";
            // 
            // textCno
            // 
            this.textCno.Location = new System.Drawing.Point(134, 348);
            this.textCno.Name = "textCno";
            this.textCno.Size = new System.Drawing.Size(160, 25);
            this.textCno.TabIndex = 13;
            // 
            // bookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.Controls.Add(this.textCno);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.listbook);
            this.Controls.Add(this.buttonReturnBook);
            this.Controls.Add(this.buttonSearch);
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
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonReturnBook;
        private System.Windows.Forms.ListView listbook;
        private System.Windows.Forms.ColumnHeader bno;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader press;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ColumnHeader stock;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.TextBox textCno;
    }
}