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
    public partial class viewTotalMonthIncome : Form
    {
        public viewTotalMonthIncome()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

            string month = cbMonth.Text;
            DateTime date = DateTime.Now;
            string year = date.Year.ToString();
            string StartDate = "";
            string EndDate = "";

            if (month == "Jan")
            {
                StartDate = year + "/01/01";
                EndDate = year + "/01/28";
            }
            else if (month == "Feb")
            {
                StartDate = year + "/02/01";
                EndDate = year + "/02/28";
            }
            else if (month == "Mar")
            {
                StartDate = year + "/03/01";
                EndDate = year + "/03/28";
            }
            else if (month == "Apr")
            {
                StartDate = year + "/04/01";
                EndDate = year + "/04/28";
            }
            else if (month == "May")
            {
                StartDate = year + "/05/01";
                EndDate = year + "/05/28";
            }
            else if (month == "Jun")
            {
                StartDate = year + "/06/01";
                EndDate = year + "/06/28";
            }
            else if (month == "Jul")
            {
                StartDate = year + "/07/01";
                EndDate = year + "/07/28";
            }
            else if (month == "Aug")
            {
                StartDate = year + "/08/01";
                EndDate = year + "/08/28";
            }
            else if (month == "Sep")
            {
                StartDate = year + "/09/01";
                EndDate = year + "/09/28";
            }
            else if (month == "Oct")
            {
                StartDate = year + "/10/01";
                EndDate = year + "/10/28";
            }
            else if (month == "Nov")
            {
                StartDate = year + "/11/01";
                EndDate = year + "/11/28";
            }
            else if (month == "Dec")
            {
                StartDate = year + "/12/01";
                EndDate = year + "/12/28";
            }
            else
            {
                MessageBox.Show("Please Fill in the Date");
            }

            report report = new report();
            string result = report.ViewIncome(StartDate, EndDate);
            lblIncome.Text = result;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void viewTotalMonthIncome_Load(object sender, EventArgs e)
        {

        }
    }
}
