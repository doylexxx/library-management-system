using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryDB lb = new LibraryDB("Library", "sa", "111");
            var state = lb.Login(boxID.Text,boxpassword.Text);
            switch (state)
            {
                case LibraryDB.LoginStatus.Wrong:
                    MessageBox.Show("Wrong password. Try again or click Forgot password to reset it.");
                    break;
                case LibraryDB.LoginStatus.NotExist:
                    MessageBox.Show("Couldn't find your account ID.");
                    break;
                case LibraryDB.LoginStatus.Success:
                    this.Hide();
                    interfaceMain main_i = new interfaceMain(lb);
                    main_i.Show();
                    break;
            }
        }

        private void boxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkforget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
