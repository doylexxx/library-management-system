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
            this.label5 = new System.Windows.Forms.Label();
            this.textYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.listbook.Location = new System.Drawing.Point(59, 81);
            this.listbook.Name = "listbook";
            this.listbook.Size = new System.Drawing.Size(800, 173);
            this.listbook.TabIndex = 4;
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
            this.lbid.Location = new System.Drawing.Point(49, 305);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(37, 20);
            this.lbid.TabIndex = 10;
            this.lbid.Text = "Bno";
            this.lbid.Click += new System.EventHandler(this.lbid_Click);
            // 
            // textBno
            // 
            this.textBno.Location = new System.Drawing.Point(98, 300);
            this.textBno.Name = "textBno";
            this.textBno.Size = new System.Drawing.Size(160, 25);
            this.textBno.TabIndex = 19;
            this.textBno.TextChanged += new System.EventHandler(this.textBno_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.BlueViolet;
            this.label8.Location = new System.Drawing.Point(12, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Catelogy";
            // 
            // textCatelogy
            // 
            this.textCatelogy.Location = new System.Drawing.Point(98, 350);
            this.textCatelogy.Name = "textCatelogy";
            this.textCatelogy.Size = new System.Drawing.Size(160, 25);
            this.textCatelogy.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.BlueViolet;
            this.label7.Location = new System.Drawing.Point(45, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Title";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(98, 400);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(160, 25);
            this.textTitle.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.BlueViolet;
            this.label6.Location = new System.Drawing.Point(39, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Press";
            // 
            // textPress
            // 
            this.textPress.Location = new System.Drawing.Point(98, 450);
            this.textPress.Name = "textPress";
            this.textPress.Size = new System.Drawing.Size(160, 25);
            this.textPress.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.BlueViolet;
            this.label5.Location = new System.Drawing.Point(294, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Year";
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(341, 300);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(160, 25);
            this.textYear.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.BlueViolet;
            this.label4.Location = new System.Drawing.Point(275, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Author";
            // 
            // textAuthor
            // 
            this.textAuthor.Location = new System.Drawing.Point(341, 350);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(160, 25);
            this.textAuthor.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(290, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Price";
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(341, 400);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(160, 25);
            this.textPrice.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.BlueViolet;
            this.label2.Location = new System.Drawing.Point(289, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Total";
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(341, 450);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(160, 25);
            this.textTotal.TabIndex = 33;
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
            this.buttonSearch.Location = new System.Drawing.Point(580, 415);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(160, 60);
            this.buttonSearch.TabIndex = 34;
            this.buttonSearch.Text = "search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bno",
            "Catelogy",
            "Title",
            "Press",
            "Year",
            "Author",
            "Price",
            "Total"});
            this.comboBox1.Location = new System.Drawing.Point(642, 305);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.BlueViolet;
            this.label9.Location = new System.Drawing.Point(576, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "关键词";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.BlueViolet;
            this.checkBox1.Location = new System.Drawing.Point(583, 349);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 19);
            this.checkBox1.TabIndex = 39;
            this.checkBox1.Text = "排序";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonDsc);
            this.panel1.Controls.Add(this.radioButtonAsc);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(580, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 34);
            this.panel1.TabIndex = 40;
            // 
            // radioButtonDsc
            // 
            this.radioButtonDsc.AutoSize = true;
            this.radioButtonDsc.ForeColor = System.Drawing.Color.BlueViolet;
            this.radioButtonDsc.Location = new System.Drawing.Point(125, 6);
            this.radioButtonDsc.Name = "radioButtonDsc";
            this.radioButtonDsc.Size = new System.Drawing.Size(58, 19);
            this.radioButtonDsc.TabIndex = 1;
            this.radioButtonDsc.TabStop = true;
            this.radioButtonDsc.Text = "降序";
            this.radioButtonDsc.UseVisualStyleBackColor = true;
            // 
            // radioButtonAsc
            // 
            this.radioButtonAsc.AutoSize = true;
            this.radioButtonAsc.ForeColor = System.Drawing.Color.BlueViolet;
            this.radioButtonAsc.Location = new System.Drawing.Point(3, 6);
            this.radioButtonAsc.Name = "radioButtonAsc";
            this.radioButtonAsc.Size = new System.Drawing.Size(58, 19);
            this.radioButtonAsc.TabIndex = 0;
            this.radioButtonAsc.TabStop = true;
            this.radioButtonAsc.Text = "升序";
            this.radioButtonAsc.UseVisualStyleBackColor = true;
            // 
            // bookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textAuthor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonDsc;
        private System.Windows.Forms.RadioButton radioButtonAsc;
    }
}