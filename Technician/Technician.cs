using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace group3assignment
{
    internal class Technician
    {
        private string name;
        private string email;
        private string number;


        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public string Email { get => email; set => email = value; }
        public string PhoneNum { get => number; set => number = value; }

        public Technician(string n, string e, string num)
        {
            name = n;
            email = e;
            number = num;
            
        }
        public Technician(string n)
        {
            name = n;
        }

        public static void viewProfile(Technician o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Technician where TechnicianName='" + o1.name + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.email = rd.GetString(2);
                o1.number = rd.GetString(3);
            }
            con.Close();
        }



        public string UpdateTechnician(string n,string em, string num)
        {
            string status;
            con.Open();


            name = n;
            email = em;
            number = num;

            SqlCommand cmd = new SqlCommand("update technician set email='" + email + "',phoneNumber='" + number + "' where Technicianname='" + name + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Success:";

            else
                status = "Unable to Update";
            con.Close();
            return status;
        }

       







    }
}
