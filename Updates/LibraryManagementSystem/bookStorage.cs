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

        private void lbid_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textCatelogy_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_store_Click(object sender, EventArgs e)
        {
            string storeString = textBno.Text + '\t' + textCatelogy.Text + '\t' + textTitle.Text + '\t' +
                textPress.Text + '\t' + textYear.Text + '\t' + textAuthor.Text + '\t' +
                textPrice.Text + '\t' + textTotal.Text;
            ldb.AddBook(storeString);
        }
    }
}
