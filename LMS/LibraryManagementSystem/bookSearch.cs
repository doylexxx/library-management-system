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
            DataSet dss = ldb.BookSearch("","","","","","title",false,true);
            refreshlistview(dss);
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
            panel1.Enabled=checksort.Checked;
            cbsortkey.Enabled = checksort.Checked;
        }

        private void listbook_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool desc = radioButtonDsc.Checked;
            DataSet ds = ldb.BookSearch(textBno.Text, textCatelogy.Text, textTitle.Text, textPress.Text, textAuthor.Text, cbsortkey.Text, desc,checksort.Checked);          
            refreshlistview(ds);
        }

        private void refreshlistview(DataSet ds)
        {

            int rowCount, columnCount, i, j;
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

        private void textAuthor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
