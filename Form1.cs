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

namespace ListView_Acces
{
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\PersonDB.accdb");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillgrid();
        }
        void fillgrid()
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from PersonTbl order by ID ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Update PersonTbl set Name='"+txtName.Text+"',age="+txtAge.Text+" where ID="+txtID.Text+"", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated...");

            clearText();
            fillgrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Delete from PersonTbl where ID="+txtID.Text+"", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted...");

            clearText();
            fillgrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into PersonTbl (Name, Age) values('" + txtName.Text + "'," + txtAge.Text + ") ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved...");

            clearText();
            fillgrid();

        }

        void clearText()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
        }
    }
}
