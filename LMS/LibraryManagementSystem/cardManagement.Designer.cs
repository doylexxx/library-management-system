namespace LibraryManagementSystem
{
    partial class cardManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cardManagement));
            this.lbcardMwd = new System.Windows.Forms.Label();
            this.lbcardM = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.PictureBox();
            this.lbcardID = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listCard = new System.Windows.Forms.ListView();
            this.columncno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textName = new System.Windows.Forms.TextBox();
            this.textDepart = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbdepat = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // lbcardMwd
            // 
            this.lbcardMwd.BackColor = System.Drawing.Color.BlueViolet;
            this.lbcardMwd.Location = new System.Drawing.Point(0, 0);
            this.lbcardMwd.Name = "lbcardMwd";
            this.lbcardMwd.Size = new System.Drawing.Size(960, 55);
            this.lbcardMwd.TabIndex = 6;
            // 
            // lbcardM
            // 
            this.lbcardM.AutoSize = true;
            this.lbcardM.BackColor = System.Drawing.Color.BlueViolet;
            this.lbcardM.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbcardM.ForeColor = System.Drawing.Color.White;
            this.lbcardM.Location = new System.Drawing.Point(65, 14);
            this.lbcardM.Name = "lbcardM";
            this.lbcardM.Size = new System.Drawing.Size(190, 27);
            this.lbcardM.TabIndex = 7;
            this.lbcardM.Text = "Card Management";
            this.lbcardM.Click += new System.EventHandler(this.lbcardM_Click);
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
            // lbcardID
            // 
            this.lbcardID.AutoSize = true;
            this.lbcardID.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbcardID.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbcardID.Location = new System.Drawing.Point(520, 130);
            this.lbcardID.Name = "lbcardID";
            this.lbcardID.Size = new System.Drawing.Size(62, 20);
            this.lbcardID.TabIndex = 9;
            this.lbcardID.Text = "Card ID";
            this.lbcardID.Click += new System.EventHandler(this.lbcardID_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(646, 128);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(170, 25);
            this.textID.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(646, 370);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(170, 45);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add Card";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(646, 443);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(170, 45);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete Card";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listCard
            // 
            this.listCard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columncno,
            this.columnName,
            this.columnDep,
            this.columnType});
            this.listCard.Location = new System.Drawing.Point(70, 128);
            this.listCard.Name = "listCard";
            this.listCard.Size = new System.Drawing.Size(410, 360);
            this.listCard.TabIndex = 8;
            this.listCard.UseCompatibleStateImageBehavior = false;
            this.listCard.View = System.Windows.Forms.View.Details;
            this.listCard.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columncno
            // 
            this.columncno.Text = "CNO";
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnDep
            // 
            this.columnDep.Text = "Department";
            this.columnDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDep.Width = 120;
            // 
            // columnType
            // 
            this.columnType.Text = "Type";
            this.columnType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(646, 184);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(170, 25);
            this.textName.TabIndex = 1;
            // 
            // textDepart
            // 
            this.textDepart.Location = new System.Drawing.Point(646, 237);
            this.textDepart.Name = "textDepart";
            this.textDepart.Size = new System.Drawing.Size(170, 25);
            this.textDepart.TabIndex = 2;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbName.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbName.Location = new System.Drawing.Point(520, 186);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(52, 20);
            this.lbName.TabIndex = 10;
            this.lbName.Text = "Name";
            // 
            // lbdepat
            // 
            this.lbdepat.AutoSize = true;
            this.lbdepat.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbdepat.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbdepat.Location = new System.Drawing.Point(520, 239);
            this.lbdepat.Name = "lbdepat";
            this.lbdepat.Size = new System.Drawing.Size(97, 20);
            this.lbdepat.TabIndex = 11;
            this.lbdepat.Text = "Department";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbType.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbType.Location = new System.Drawing.Point(520, 286);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(45, 20);
            this.lbType.TabIndex = 12;
            this.lbType.Text = "Type";
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.White;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Teacher",
            "Graduate",
            "Undergraduate",
            "Officer"});
            this.cbType.Location = new System.Drawing.Point(646, 286);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(170, 28);
            this.cbType.TabIndex = 3;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cardManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbdepat);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.textDepart);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.listCard);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.lbcardID);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.lbcardM);
            this.Controls.Add(this.lbcardMwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cardManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.cardManagemetn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbcardMwd;
        private System.Windows.Forms.Label lbcardM;
        private System.Windows.Forms.PictureBox buttonReturn;
        private System.Windows.Forms.Label lbcardID;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListView listCard;
        private System.Windows.Forms.ColumnHeader columncno;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnDep;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textDepart;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbdepat;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ComboBox cbType;
    }
}