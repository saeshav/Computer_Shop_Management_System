using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group3assignment
{
    internal class Customer
    {
        private string name;
        private string email;
        private string phoneNumber;
        private string serviceType;
        private string totalAmount;
        private string paymentStatus;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Customer(string n, string e, string num, string type, string Amount, string Fee)
        {
            name = n;
            email = e;
            phoneNumber = num;
            serviceType = type;
            totalAmount = Amount;
            paymentStatus = Fee;
        }

        public Customer(string n)
        {
            name = n;
        }
        public string AddCustomer()
        {

            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Customer(name,email,phoneNumber,serviceType,totalAmount,paymentStatus)values (@name,@em,@num,@type,@amount,@fee)", con);

            SqlCommand cmd2 = new SqlCommand("insert into Users(username,password,role) values(@name,'123','customer')", con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd2.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@em", email);
            cmd.Parameters.AddWithValue("@num", phoneNumber);
            cmd.Parameters.AddWithValue("@type", serviceType);
            cmd.Parameters.AddWithValue("amount", totalAmount);
            cmd.Parameters.AddWithValue("fee", paymentStatus);


            cmd2.ExecuteNonQuery();
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Register Success";
            else
                status = "Unable to Register";
            con.Close();
            return status;
        
        }
    }
}





