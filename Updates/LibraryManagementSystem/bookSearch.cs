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
    public partial class bookSearch : Form
    {
        public LibraryDB ldb;
        public bookSearch(LibraryDB lb)
        {
            InitializeComponent();
            ldb = lb;
        }

        private void buttonreturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            interfaceMain main_i = new interfaceMain(ldb);
            main_i.Show();
        }

        private void bookSearch_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lbid_Click(object sender, EventArgs e)
        {

        }

        private void textBno_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled=checkBox1.Checked;
        }
    }
}
