using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group3assignment
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }


        SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtResult.Text += "**********************************************\n";
            txtResult.Text += "********       Payment Receipt       **********\n";
            txtResult.Text += "**********************************************\n";
            txtResult.Text += "Date :" + DateTime.Now + "\n\n";

            txtResult.Text += "Customer Name : " + cmbCustomer.Text + "\n\n";
            txtResult.Text += "Service Type : " + txtType.Text + "\n\n";
            txtResult.Text += "Total Amount : " + txtFees.Text + "\n\n";

            txtResult.Text += "\n                          Signature ";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmbCustomer.Text = "";
            txtType.Text = "";
            txtFees.Text = "";
            txtResult.Text = "";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtResult.Text, new Font("microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            SqlCommand sm = new SqlCommand("Update Customer set paymentStatus = '"+txtPayment.Text+"' where name = '"+cmbCustomer.Text+"'",sc);

            sc.Open();

            sm.ExecuteNonQuery();

            sc.Close();

            MessageBox.Show("Payment Succesful and Updated");
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            comboBox();
        }
        public void comboBox()
        {
            cmbCustomer.Items.Clear();
            sc.Open();
            SqlCommand cmd = sc.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Customer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbCustomer.Items.Add(dr["name"].ToString());
            }



            sc.Close();
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            sc.Open();
            SqlCommand cmd = sc.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Customer where name='"+ cmbCustomer.SelectedItem.ToString()+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtType.Text = dr["serviceType"].ToString();
                txtFees.Text = dr["totalAmount"].ToString();
            }



            sc.Close();
        }
    }
}
