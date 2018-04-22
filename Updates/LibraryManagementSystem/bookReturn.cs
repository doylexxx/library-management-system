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

        private void refreshlistview()
        {

            int rowCount, columnCount, i, j;
            DataSet ds = ldb.ListBorrow(textCno.Text);
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
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            refreshlistview();
        }
    }
}
