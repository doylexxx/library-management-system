using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class cardManagement : Form
    {
        LibraryDB ldb;

        public cardManagement( LibraryDB lb )
        {
            InitializeComponent();
            ldb = lb;
            refreshlistview();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            interfaceMain main_i = new interfaceMain(ldb);
            main_i.Show();
        }

        private void lbcardID_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cardManagemetn_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ldb.AddCard(textID.Text, textName.Text, textDepart.Text, cbType.Text[0]);
            refreshlistview();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listCard.SelectedItems.Count == 0) MessageBox.Show("Please select a card.");
            else
            {
                string cno = listCard.SelectedItems[0].Text;
                if (ldb.CountBorrow(cno) == 0)
                {    
                    if (MessageBox.Show(string.Format("Delete {0} ?", cno.Trim()),
                        "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        ldb.DeleteCard(cno);
                        refreshlistview();
                    }
                }
                else
                    MessageBox.Show("Can't delete this card. Please return all the book! ");
            }
        }

        private void refreshlistview()
        {
            int rowCount, columnCount, i, j;

            DataSet ds = ldb.SQL("select * from card");

            rowCount = ds.Tables[0].Rows.Count;
            columnCount = ds.Tables[0].Columns.Count;

            listCard.BeginUpdate();
            listCard.Items.Clear();

            string[] lvitem = new string[columnCount];

            for (i = 0; i < rowCount; i++)
            {
                for (j = 0; j < columnCount; j++)
                {
                    lvitem[j] = ds.Tables[0].Rows[i][j].ToString();
                }
                ListViewItem lvi = new ListViewItem(lvitem);
                listCard.Items.Add(lvi);
            }

            listCard.EndUpdate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbcardM_Click(object sender, EventArgs e)
        {

        }
    }
}
