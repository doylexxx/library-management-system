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
    public partial class interfaceMain : Form
    {
        public LibraryDB ldb;

        public interfaceMain( LibraryDB lb )
        {
            InitializeComponent();
            ldb = lb;
        }

        private void interfaceMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonStorage_Click(object sender, EventArgs e)
        {
            this.Hide();
            bookStorage bS = new bookStorage(ldb);
            bS.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            bookSearch bSc = new bookSearch(ldb);
            bSc.Show();
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            bookBorrow bB = new bookBorrow(ldb);
            bB.Show();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            bookReturn bR = new bookReturn(ldb);
            bR.Show();
        }

        private void buttonCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            cardManagement cM = new cardManagement( ldb );
            cM.Show();
        }
    }
}
