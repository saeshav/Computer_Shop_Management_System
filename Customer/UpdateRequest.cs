using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group3assignment
{
    internal class UpdateRequest
    {
        private string ID;
        private string service;
        

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\testing1v2\testing1\myCS.mdf;Integrated Security=True");

        public string ServiceId { get => ID; set => ID = value; }
        public string ServiceType { get => service; set => service = value; }
        public UpdateRequest(string n, string e, string num)
        {
           ID  = n;
           service = e;
            
        }

        public UpdateRequest (string n)
        {
            ID = n;
        }

        public string UpdateService(string n, string e)
        {
            string status;
            con.Open();

            ID = n;
            service = e;

            SqlCommand cmd = new SqlCommand("update Customer set serviceType='" + service + "' where CustomerId='" +ID+ "'", con);
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
