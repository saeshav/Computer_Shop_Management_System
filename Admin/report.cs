using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace group3assignment
{
    class report
    {

        public DataTable MonthlyReport(string StartDate, string EndDate)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

            con.Open();
            string q1 = "Select CustomerID,name,serviceType,totalAmount from Customer where collectionDate Between '" + StartDate + "' AND '" + EndDate + "'";

            SqlCommand cmd1 = new SqlCommand(q1, con);
            cmd1.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public string ViewIncome(string StartDate, string EndDate)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

            con.Open();
            string q1 = "Select Sum(totalAmount) from Customer where collectionDate Between '" + StartDate + "' AND '" + EndDate + "'";
            SqlCommand cmd = new SqlCommand(q1, con);
            string total = cmd.ExecuteScalar().ToString();
            if (total == "")
            {
                MessageBox.Show("no value");
                return "0";
            }
            con.Close();

            return total;
        }
    }
}
