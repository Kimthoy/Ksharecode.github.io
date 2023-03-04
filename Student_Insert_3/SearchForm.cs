using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Student_Insert_3
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=book.accdb");
            OleDbCommand cmd = new OleDbCommand("Select*From Books where BookId like'%" + textSearchID.Text + "'",con);

            con.Open();
            OleDbDataReader drd = cmd.ExecuteReader();
            drd.Read();

            txtBookId.Text = drd[0].ToString();
            txtAuthorId.Text = drd[1].ToString();
            txtTittle.Text = drd[2].ToString();
            txtPage.Text = drd[3].ToString();
            con.Close();
        }
    }
}
