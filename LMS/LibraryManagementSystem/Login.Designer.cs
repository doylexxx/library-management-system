namespace LibraryManagementSystem
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbaccountID = new System.Windows.Forms.Label();
            this.lbpassword = new System.Windows.Forms.Label();
            this.boxID = new System.Windows.Forms.TextBox();
            this.boxpassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.linkforget = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbaccountID
            // 
            this.lbaccountID.AutoSize = true;
            this.lbaccountID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaccountID.ForeColor = System.Drawing.Color.DimGray;
            this.lbaccountID.Location = new System.Drawing.Point(40, 160);
            this.lbaccountID.Name = "lbaccountID";
            this.lbaccountID.Size = new System.Drawing.Size(32, 23);
            this.lbaccountID.TabIndex = 0;
            this.lbaccountID.Text = "ID";
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpassword.ForeColor = System.Drawing.Color.DimGray;
            this.lbpassword.Location = new System.Drawing.Point(40, 200);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(98, 23);
            this.lbpassword.TabIndex = 0;
            this.lbpassword.Text = "Password";
            // 
            // boxID
            // 
            this.boxID.BackColor = System.Drawing.Color.Snow;
            this.boxID.Location = new System.Drawing.Point(150, 158);
            this.boxID.Name = "boxID";
            this.boxID.Size = new System.Drawing.Size(160, 25);
            this.boxID.TabIndex = 0;
            this.boxID.TextChanged += new System.EventHandler(this.boxID_TextChanged);
            // 
            // boxpassword
            // 
            this.boxpassword.BackColor = System.Drawing.Color.Snow;
            this.boxpassword.Location = new System.Drawing.Point(150, 198);
            this.boxpassword.Name = "boxpassword";
            this.boxpassword.PasswordChar = '*';
            this.boxpassword.Size = new System.Drawing.Size(160, 25);
            this.boxpassword.TabIndex = 1;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(95, 330);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(170, 45);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkforget
            // 
            this.linkforget.ActiveLinkColor = System.Drawing.Color.BlueViolet;
            this.linkforget.AutoSize = true;
            this.linkforget.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkforget.LinkColor = System.Drawing.Color.Violet;
            this.linkforget.Location = new System.Drawing.Point(191, 240);
            this.linkforget.Name = "linkforget";
            this.linkforget.Size = new System.Drawing.Size(119, 14);
            this.linkforget.TabIndex = 3;
            this.linkforget.TabStop = true;
            this.linkforget.Text = "Forgot Password?";
            this.linkforget.VisitedLinkColor = System.Drawing.Color.BlueViolet;
            this.linkforget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkforget_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(38, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "My Library:)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlueViolet;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(95, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(360, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkforget);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.boxpassword);
            this.Controls.Add(this.boxID);
            this.Controls.Add(this.lbpassword);
            this.Controls.Add(this.lbaccountID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "interfaceLogin";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbaccountID;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.TextBox boxID;
        private System.Windows.Forms.TextBox boxpassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.LinkLabel linkforget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

