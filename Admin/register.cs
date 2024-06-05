using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group3assignment
{
    internal class register
    {
        private string username;
        private string password;
        private string name;
        private string email;
        private string contact;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public register(string username, string password, string name, string email, string contact)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.email = email;
            this.contact = contact;
        }


        public void register_role(string role)
        {

            con.Open();

            string q2 = "INSERT INTO Users VALUES ('" + username + "','" + password + "','" + role + "')";

            SqlCommand cmd2 = new SqlCommand(q2, con);
            int i = cmd2.ExecuteNonQuery();

            con.Close();

            if (i > 0)
            {
                if (role == "receptionist")
                {
                    registerReceptionist();
                    
                }
                else if (role == "technician")
                {
                    registerTechnician();
                   
                }
            }


        }


        public void registerReceptionist(){

            string q1 = "INSERT INTO Receptionist VALUES ('" + name + "','" + email + "','" + contact + "')";

            con.Open();
            SqlCommand cmd1 = new SqlCommand(q1, con);
            int n = cmd1.ExecuteNonQuery();
            con.Close();
            if (n > 0)
                {
                    MessageBox.Show("Register Successfully");
                }
                else
                {
                    MessageBox.Show("Register Unsuccessfully");
                }
           
            }


        public void registerTechnician()
        {
            string q1 = "INSERT INTO Technician VALUES ('" + name + "','" + email + "','" + contact + "')";
            con.Open();
            SqlCommand cmd1 = new SqlCommand(q1, con);
            int n = cmd1.ExecuteNonQuery();
            con.Close();
            if (n > 0)
            {
                MessageBox.Show("Register Successfully");
            }
            else
            {
                MessageBox.Show("Register Unsuccessfully");
            }
         
        }

    }

}
