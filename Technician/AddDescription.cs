using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace group3assignment
{
    public partial class AddDescription : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\testing1v2\testing1\myCS.mdf;Integrated Security=True");
        public AddDescription()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e) 
        {

        }

        private void AddDescription_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void add_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText ="update customer set description='"+txtadd.Text+"',collectionDate='" + date.Text + "'where CustomerID='" +txtid.Text+ "'";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("record inserted Successfully");
            this.Close();

        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select customerID,name,serviceType,description,collectionDate from Customer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
