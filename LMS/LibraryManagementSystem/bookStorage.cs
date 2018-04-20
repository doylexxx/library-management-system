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
    public partial class bookStorage : Form
    {
        public LibraryDB ldb;
        public bookStorage(LibraryDB lb)
        {
            InitializeComponent();
            ldb = lb;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            interfaceMain main_i = new interfaceMain(ldb);
            main_i.Show();
        }

        private void bookStorage_Load(object sender, EventArgs e)
        {

        }
    }
}
