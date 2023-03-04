using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Insert_3
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=book.accdb");
            OleDbCommand cmd = new OleDbCommand("delete from books where bookid='" + txtId.Text+"'",con);

            con.Open();
            int effectedRow = cmd.ExecuteNonQuery();
            con.Close();
            if (effectedRow > 0)
            {
                MessageBox.Show("The Row was deleted !");
            }
            else
            {
                MessageBox.Show("Delete Is Failed");
            }
        }
    }
}
