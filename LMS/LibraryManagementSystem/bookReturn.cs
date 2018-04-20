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
    
    public partial class bookReturn : Form
    {
        public LibraryDB ldb;
        public bookReturn(LibraryDB lb)
        {
            InitializeComponent(  );
            ldb = lb;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            interfaceMain main_i = new interfaceMain(ldb);
            main_i.Show();
        }

        private void bookReturn_Load(object sender, EventArgs e)
        {

        }
    }
}
