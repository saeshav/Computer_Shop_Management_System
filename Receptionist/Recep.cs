using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group3assignment
{
    internal class Recep
    {
        private string name;
        private string email;
        private string number;


        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Email { get => email; set => email = value; }
        public string Number { get => number; set => number = value; }

        public Recep(string n, string e, string num)
        {
            name = n;
            email = e;
            number = num;

        }
        public Recep(string n)
        {
            name = n;
        }

        public static void viewProfile(Recep o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Receptionist where ReceptionistName='" + o1.name + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.email = rd.GetString(2);
                o1.number = rd.GetString(3);
            }
            con.Close();
        }

        public string UpdateProfile(string n, string em, string num)
        {
            string status;
            con.Open();


            name = n;
            email = em;
            number = num;

            SqlCommand cmd = new SqlCommand("update Receptionist set email='" + email + "',phoneNumber='" + number + "' where Receptionistname='" + name + "'", con);
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
