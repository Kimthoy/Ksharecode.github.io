using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Student_Insert_3
{
    public partial class Update : Form
    {

        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=book.accdb");
            OleDbCommand cmd = new OleDbCommand("update books set bookid='" + txtId.Text+"',authorid='"+txtAuthor.Text+"',tittle='" +txtTittle.Text+ "',pages='"+txtPage.Text+"'where bookid='"+txtId.Text+"'",con);


            con.Open();
            int effectedRow = cmd.ExecuteNonQuery();
            con.Close();
            if (effectedRow > 0)
            {
                MessageBox.Show("The Row  was Updated");
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void TxtAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTittle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
