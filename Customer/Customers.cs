using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group3assignment
{
    internal class Customers
    {
        private string name;
        private string email;
        private string phone;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\testing1v2\testing1\myCS.mdf;Integrated Security=True");

        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phone; set => phone = value; }

        public Customers(string n, string e, string num)
        {
            name = n;
            email = e;
            phone = num;
        }

        public Customers(string n)
        {
            name = n;
        }

        public string UpdateCustomer(string n, string e, string num)
        {
            string status;
            con.Open();

            name = n;
            email = e;
            phone = num;

            SqlCommand cmd = new SqlCommand("update customer set email='" + email + "',phoneNumber='" + PhoneNumber + "' where name='" + name + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = " Update Success:";
            else
                status = "Unable to Update";
            con.Close();
            return status;
        }
    }
}
