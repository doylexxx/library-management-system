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
            refreshlistview();
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
            MessageBox.Show("Store success! ");
        }

        private void textTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dia = new OpenFileDialog();
            dia.InitialDirectory = Application.StartupPath;
            dia.Multiselect = false;
            dia.Filter = "文本文件|*.txt|所有文件|*.*";
            dia.FilterIndex = 0;
            if(dia.ShowDialog()==DialogResult.OK)
            {
                int i = ldb.AddBooks(dia.FileName);
                MessageBox.Show(string.Format("Add {0} book(s). ", i));
            }
        }

        private void refreshlistview()
        {

            int rowCount, columnCount, i, j;
            DataSet ds = ldb.SQL("select * from book");
            rowCount = ds.Tables[0].Rows.Count;
            columnCount = ds.Tables[0].Columns.Count;

            listbooks.BeginUpdate();
            listbooks.Items.Clear();

            string[] lvitem = new string[columnCount];

            for (i = 0; i < rowCount; i++)
            {
                for (j = 0; j < columnCount; j++)
                {
                    lvitem[j] = ds.Tables[0].Rows[i][j].ToString();
                }
                ListViewItem lvi = new ListViewItem(lvitem);
                listbooks.Items.Add(lvi);
            }

            listbooks.EndUpdate();
        }

        private void listbooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
