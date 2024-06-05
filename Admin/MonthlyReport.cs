using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group3assignment.Admin
{
    public partial class MonthlyReport : Form
    {
        public MonthlyReport()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string month = cbMonth.Text;
            string StartDate = "";
            string EndDate = "";
            DateTime date = DateTime.Now;
            string year = date.Year.ToString();
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
            DataTable result = report.MonthlyReport(StartDate, EndDate);
            dataGridView1.DataSource = result;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
