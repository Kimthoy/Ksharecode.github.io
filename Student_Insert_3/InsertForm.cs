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
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void InsertForm_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Please insert Data !");
                txtId.Focus();
            }
            else
            {
                String command = "insert into books values('" + txtId.Text + "','" + txtAuthor.Text + "','" + txtTittle.Text + "'," + txtPage.Text + ")";

                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=book.accdb");
                OleDbCommand cmd = new OleDbCommand(command, con);


                con.Open();
                int effectedRow = cmd.ExecuteNonQuery();
                con.Close();
                if (effectedRow>0)
                {
                    MessageBox.Show("Insert Are SuccessFully !");
                }
                else {
                    MessageBox.Show("Insert Is Failed");
                }
            }
        }

        private void TxtPage_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPage.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numbers.");
                SendKeys.Send("{BS}");
            }
        }

        private void TxtTittle_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTittle.Text, "[^a-zA-Z#$%&]"))
            {
                MessageBox.Show("Please Enter Only Text.");
                SendKeys.Send("{BS}");
            }
        }
    }
}
