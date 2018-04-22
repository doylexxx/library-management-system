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
            this.textBno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textCatelogy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textPress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textAuthor = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.cbsortkey = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checksort = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonDsc = new System.Windows.Forms.RadioButton();
            this.radioButtonAsc = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.buttonreturn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbbookSearchwd
            // 
            this.lbbookSearchwd.BackColor = System.Drawing.Color.BlueViolet;
            this.lbbookSearchwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbbookSearchwd.Location = new System.Drawing.Point(0, 0);
            this.lbbookSearchwd.Name = "lbbookSearchwd";
            this.lbbookSearchwd.Size = new System.Drawing.Size(960, 55);
            this.lbbookSearchwd.TabIndex = 10;
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
            this.label1.TabIndex = 11;
            this.label1.Text = "Book Search";
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
            this.listbook.Size = new System.Drawing.Size(800, 200);
            this.listbook.TabIndex = 9;
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
            this.lbid.Location = new System.Drawing.Point(76, 350);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(37, 20);
            this.lbid.TabIndex = 12;
            this.lbid.Text = "Bno";
            this.lbid.Click += new System.EventHandler(this.lbid_Click);
            // 
            // textBno
            // 
            this.textBno.Location = new System.Drawing.Point(160, 345);
            this.textBno.Name = "textBno";
            this.textBno.Size = new System.Drawing.Size(160, 25);
            this.textBno.TabIndex = 0;
            this.textBno.TextChanged += new System.EventHandler(this.textBno_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.BlueViolet;
            this.label8.Location = new System.Drawing.Point(76, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Category";
            // 
            // textCatelogy
            // 
            this.textCatelogy.Location = new System.Drawing.Point(160, 385);
            this.textCatelogy.Name = "textCatelogy";
            this.textCatelogy.Size = new System.Drawing.Size(160, 25);
            this.textCatelogy.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.BlueViolet;
            this.label7.Location = new System.Drawing.Point(76, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Title";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(160, 425);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(160, 25);
            this.textTitle.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.BlueViolet;
            this.label6.Location = new System.Drawing.Point(76, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Press";
            // 
            // textPress
            // 
            this.textPress.Location = new System.Drawing.Point(160, 465);
            this.textPress.Name = "textPress";
            this.textPress.Size = new System.Drawing.Size(160, 25);
            this.textPress.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.BlueViolet;
            this.label4.Location = new System.Drawing.Point(375, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Author";
            // 
            // textAuthor
            // 
            this.textAuthor.Location = new System.Drawing.Point(456, 345);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(160, 25);
            this.textAuthor.TabIndex = 4;
            this.textAuthor.TextChanged += new System.EventHandler(this.textAuthor_TextChanged);
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
            this.buttonSearch.Location = new System.Drawing.Point(720, 430);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(160, 60);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // cbsortkey
            // 
            this.cbsortkey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsortkey.FormattingEnabled = true;
            this.cbsortkey.Items.AddRange(new object[] {
            "Bno",
            "Catelogy",
            "Title",
            "Press",
            "Year",
            "Author",
            "Price",
            "Total"});
            this.cbsortkey.Location = new System.Drawing.Point(456, 465);
            this.cbsortkey.Name = "cbsortkey";
            this.cbsortkey.Size = new System.Drawing.Size(160, 23);
            this.cbsortkey.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.BlueViolet;
            this.label9.Location = new System.Drawing.Point(375, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Keyword";
            // 
            // checksort
            // 
            this.checksort.AutoSize = true;
            this.checksort.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checksort.ForeColor = System.Drawing.Color.BlueViolet;
            this.checksort.Location = new System.Drawing.Point(379, 392);
            this.checksort.Name = "checksort";
            this.checksort.Size = new System.Drawing.Size(62, 24);
            this.checksort.TabIndex = 5;
            this.checksort.Text = "Sort";
            this.checksort.UseVisualStyleBackColor = true;
            this.checksort.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonDsc);
            this.panel1.Controls.Add(this.radioButtonAsc);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(379, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 34);
            this.panel1.TabIndex = 6;
            // 
            // radioButtonDsc
            // 
            this.radioButtonDsc.AutoSize = true;
            this.radioButtonDsc.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonDsc.ForeColor = System.Drawing.Color.BlueViolet;
            this.radioButtonDsc.Location = new System.Drawing.Point(181, 6);
            this.radioButtonDsc.Name = "radioButtonDsc";
            this.radioButtonDsc.Size = new System.Drawing.Size(56, 24);
            this.radioButtonDsc.TabIndex = 1;
            this.radioButtonDsc.TabStop = true;
            this.radioButtonDsc.Text = "Dsc";
            this.radioButtonDsc.UseVisualStyleBackColor = true;
            // 
            // radioButtonAsc
            // 
            this.radioButtonAsc.AutoSize = true;
            this.radioButtonAsc.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonAsc.ForeColor = System.Drawing.Color.BlueViolet;
            this.radioButtonAsc.Location = new System.Drawing.Point(77, 6);
            this.radioButtonAsc.Name = "radioButtonAsc";
            this.radioButtonAsc.Size = new System.Drawing.Size(56, 24);
            this.radioButtonAsc.TabIndex = 0;
            this.radioButtonAsc.TabStop = true;
            this.radioButtonAsc.Text = "Asc";
            this.radioButtonAsc.UseVisualStyleBackColor = true;
            // 
            // bookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checksort);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbsortkey);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textAuthor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textCatelogy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBno);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.listbook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonreturn);
            this.Controls.Add(this.lbbookSearchwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bookSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.bookSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonreturn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbbookSearchwd;
        private System.Windows.Forms.PictureBox buttonreturn;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox textBno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textCatelogy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox cbsortkey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checksort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonDsc;
        private System.Windows.Forms.RadioButton radioButtonAsc;
    }
}