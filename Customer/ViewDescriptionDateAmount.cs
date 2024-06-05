using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace group3assignment
{
    public partial class ViewDescriptionDateAmount : Form
    {
        public ViewDescriptionDateAmount()
        {
            InitializeComponent();
        }

        private void ViewDescriptionDateAmount_Load(object sender, EventArgs e)
        {
            CustomerdataGridView1.DataSource = GetCustomer();
        }
        private DataTable GetCustomer()
        {
            DataTable dtCustomer = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["myCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                using SqlCommand cmd = new SqlCommand("select CustomerID, serviceType, totalAmount, paymentStatus,description,collectionDate FROM Customer", con);
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtCustomer.Load(reader);
                }
                return dtCustomer;
            }

        }

    }
}