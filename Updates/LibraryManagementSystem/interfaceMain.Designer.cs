namespace LibraryManagementSystem
{
    partial class interfaceMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(interfaceMain));
            this.lbtitle = new System.Windows.Forms.Label();
            this.lbwindow = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.PictureBox();
            this.buttonStorage = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonCard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.BackColor = System.Drawing.Color.BlueViolet;
            this.lbtitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbtitle.ForeColor = System.Drawing.Color.White;
            this.lbtitle.Location = new System.Drawing.Point(10, 14);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(286, 27);
            this.lbtitle.TabIndex = 0;
            this.lbtitle.Text = "Library Management System";
            // 
            // lbwindow
            // 
            this.lbwindow.BackColor = System.Drawing.Color.BlueViolet;
            this.lbwindow.Location = new System.Drawing.Point(0, 0);
            this.lbwindow.Name = "lbwindow";
            this.lbwindow.Size = new System.Drawing.Size(360, 55);
            this.lbwindow.TabIndex = 2;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(315, 13);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 30);
            this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonClose.TabIndex = 3;
            this.buttonClose.TabStop = false;
            this.buttonClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonStorage
            // 
            this.buttonStorage.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonStorage.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.buttonStorage.FlatAppearance.BorderSize = 0;
            this.buttonStorage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.buttonStorage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStorage.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStorage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonStorage.Location = new System.Drawing.Point(40, 100);
            this.buttonStorage.Name = "buttonStorage";
            this.buttonStorage.Size = new System.Drawing.Size(280, 50);
            this.buttonStorage.TabIndex = 4;
            this.buttonStorage.Text = "Book Storage";
            this.buttonStorage.UseVisualStyleBackColor = false;
            this.buttonStorage.Click += new System.EventHandler(this.buttonStorage_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSearch.Location = new System.Drawing.Point(40, 185);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(280, 50);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Book Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonBorrow.FlatAppearance.BorderSize = 0;
            this.buttonBorrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.buttonBorrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrow.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonBorrow.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBorrow.Location = new System.Drawing.Point(40, 270);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(280, 50);
            this.buttonBorrow.TabIndex = 6;
            this.buttonBorrow.Text = "Book Borrow";
            this.buttonBorrow.UseVisualStyleBackColor = false;
            this.buttonBorrow.Click += new System.EventHandler(this.buttonBorrow_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonReturn.FlatAppearance.BorderSize = 0;
            this.buttonReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.buttonReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonReturn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonReturn.Location = new System.Drawing.Point(40, 355);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(280, 50);
            this.buttonReturn.TabIndex = 7;
            this.buttonReturn.Text = "Book Return";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonCard
            // 
            this.buttonCard.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonCard.FlatAppearance.BorderSize = 0;
            this.buttonCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.buttonCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCard.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCard.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCard.Location = new System.Drawing.Point(40, 440);
            this.buttonCard.Name = "buttonCard";
            this.buttonCard.Size = new System.Drawing.Size(280, 50);
            this.buttonCard.TabIndex = 8;
            this.buttonCard.Text = "Card Management";
            this.buttonCard.UseVisualStyleBackColor = false;
            this.buttonCard.Click += new System.EventHandler(this.buttonCard_Click);
            // 
            // interfaceMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(360, 540);
            this.Controls.Add(this.buttonCard);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonBorrow);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonStorage);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.lbtitle);
            this.Controls.Add(this.lbwindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "interfaceMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.interfaceMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.Label lbwindow;
        private System.Windows.Forms.PictureBox buttonClose;
        private System.Windows.Forms.Button buttonStorage;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonCard;
    }
}