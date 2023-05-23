using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbTOWFA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ace.oledb.12.0; Data Source = Database2.accdb";
            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "delete from Tabell1 where Fname = '" + textBox1.Text + "'";
            comm.Connection = conn;
            comm.ExecuteNonQuery();
            conn.Close();
            this.Hide();
            MessageBox.Show("Data Succesfully has been removed");
            Application.Exit();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
