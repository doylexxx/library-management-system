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
        public LibraryDB ldb;

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
            ldb.AddCard(this.textID.Text.Trim().ToString(), this.textName.Text.Trim().ToString(), this.textDepart.Text.Trim().ToString(), this.cbType.Text.Trim().ToString());
            refreshlistview();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ldb.DeleteCard(this.textID.Text.Trim().ToString());
            refreshlistview();
        }

        private void refreshlistview()
        {
            int rowCount, columnCount, i, j;

            LibraryDB lb = new LibraryDB("Library", "sa", "111");
            DataSet ds = lb.SQL("select * from card");

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
    }
}
