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
            this.textID = new System.Windows.Forms.TextBox();
            this.lbbno = new System.Windows.Forms.Label();
            this.textbno = new System.Windows.Forms.TextBox();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.buttonBorrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buttonReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // lbbookBorrowwd
            // 
            this.lbbookBorrowwd.BackColor = System.Drawing.Color.BlueViolet;
            this.lbbookBorrowwd.Location = new System.Drawing.Point(0, 0);
            this.lbbookBorrowwd.Name = "lbbookBorrowwd";
            this.lbbookBorrowwd.Size = new System.Drawing.Size(960, 55);
            this.lbbookBorrowwd.TabIndex = 5;
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
            this.lbbookBorrow.TabIndex = 6;
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
            this.listbook.Location = new System.Drawing.Point(80, 120);
            this.listbook.Name = "listbook";
            this.listbook.Size = new System.Drawing.Size(800, 125);
            this.listbook.TabIndex = 4;
            this.listbook.UseCompatibleStateImageBehavior = false;
            this.listbook.View = System.Windows.Forms.View.Details;
            this.listbook.SelectedIndexChanged += new System.EventHandler(this.listbook_SelectedIndexChanged);
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
            this.lbid.Location = new System.Drawing.Point(120, 300);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(62, 20);
            this.lbid.TabIndex = 7;
            this.lbid.Text = "Card ID";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(188, 295);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(160, 25);
            this.textID.TabIndex = 0;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // lbbno
            // 
            this.lbbno.AutoSize = true;
            this.lbbno.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbbno.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbbno.Location = new System.Drawing.Point(600, 300);
            this.lbbno.Name = "lbbno";
            this.lbbno.Size = new System.Drawing.Size(74, 20);
            this.lbbno.TabIndex = 8;
            this.lbbno.Text = "Book NO";
            // 
            // textbno
            // 
            this.textbno.Location = new System.Drawing.Point(680, 295);
            this.textbno.Name = "textbno";
            this.textbno.Size = new System.Drawing.Size(160, 25);
            this.textbno.TabIndex = 1;
            // 
            // buttonsearch
            // 
            this.buttonsearch.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonsearch.FlatAppearance.BorderSize = 0;
            this.buttonsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.buttonsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonsearch.ForeColor = System.Drawing.Color.Transparent;
            this.buttonsearch.Location = new System.Drawing.Point(188, 400);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(160, 60);
            this.buttonsearch.TabIndex = 2;
            this.buttonsearch.Text = "Search";
            this.buttonsearch.UseVisualStyleBackColor = false;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonBorrow.Enabled = false;
            this.buttonBorrow.FlatAppearance.BorderSize = 0;
            this.buttonBorrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.buttonBorrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrow.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonBorrow.ForeColor = System.Drawing.Color.Transparent;
            this.buttonBorrow.Location = new System.Drawing.Point(680, 400);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(160, 60);
            this.buttonBorrow.TabIndex = 3;
            this.buttonBorrow.Text = "Borrow";
            this.buttonBorrow.UseVisualStyleBackColor = false;
            this.buttonBorrow.Click += new System.EventHandler(this.button2_Click);
            // 
            // bookBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.Controls.Add(this.buttonBorrow);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.textbno);
            this.Controls.Add(this.lbbno);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.listbook);
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
        private System.Windows.Forms.ListView listbook;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label lbbno;
        private System.Windows.Forms.TextBox textbno;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.ColumnHeader bno;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader press;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ColumnHeader stock;
    }
}