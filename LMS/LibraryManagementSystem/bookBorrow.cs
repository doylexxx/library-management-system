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
    public partial class bookBorrow : Form
    {
        public LibraryDB ldb;

        public bookBorrow(LibraryDB lb)
        {
            InitializeComponent();
            ldb = lb;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            interfaceMain main_i = new interfaceMain(ldb);
            main_i.Show();
        }

        private void bookBorrow_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ldb.CountBorrow(textID.Text) > LibraryDB.MaxBorrow)
            {
                MessageBox.Show("You can only borrow 3 books! ");
            }

            else if (ldb.BookStock(textbno.Text)==0)
            {
                string erd = ldb.EarliestReturn(textbno.Text);
                MessageBox.Show("Out of stock, the earliest return date is " + erd);
            }

            else if(ldb.Borrowed(textID.Text,textbno.Text))
            {
                MessageBox.Show("You can only borrow the same book once! ");
            }
                 

            else
            {
                ldb.Borrow(textID.Text, textbno.Text);
                refreshlistview();
                MessageBox.Show("Borrow succeed! ");
            }
            
        }

        private void refreshlistview()
        {
            
            int rowCount, columnCount, i, j;
            DataSet ds = ldb.ListBorrow(textID.Text);
            rowCount = ds.Tables[0].Rows.Count;
            columnCount = ds.Tables[0].Columns.Count;

            listbook.BeginUpdate();
            listbook.Items.Clear();

            string[] lvitem = new string[columnCount];

            for (i = 0; i < rowCount; i++)
            {
                for (j = 0; j < columnCount; j++)
                {
                    lvitem[j] = ds.Tables[0].Rows[i][j].ToString();
                }
                ListViewItem lvi = new ListViewItem(lvitem);
                listbook.Items.Add(lvi);
            }

            listbook.EndUpdate();
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            refreshlistview();
        }
    }
}
