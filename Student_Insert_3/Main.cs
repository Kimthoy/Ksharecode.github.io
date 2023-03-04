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
    public partial class Main : Form
    {
        BindingSource bind = new BindingSource();
        public Main()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=book.accdb");
            OleDbCommand cmd = new OleDbCommand("Select*From Books",con);

            
            con.Open();

            OleDbDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            bind.DataSource = dt;
            dataGridView1.DataSource = bind;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            con.Close();
        }


        private void Reload_Click(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            InsertForm insertForm = new InsertForm();
            insertForm.ShowDialog();
        }


        private void Button5_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.ShowDialog();
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            bind.MoveNext();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            bind.MovePrevious();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm();
            search.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.ShowDialog();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.loadData();
        }
    }
}
