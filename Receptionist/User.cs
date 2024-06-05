using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group3assignment
{
    internal class User
    {
        private string username;
        private string password;

        public User(string u,string p)
        {
            username = u;
            password = p;
        }

        public string Login(string un)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from Users where username='" + username + "' and password = '" + password + "'", con);

            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
            {

                SqlCommand cmd2 = new SqlCommand("select role from Users where username='" + username + "' and password= '" + password + "'", con);
                string role = cmd2.ExecuteScalar().ToString();

                if (role == "receptionist")
                {
                    ReceptionistHome a = new ReceptionistHome(un);
                    a.ShowDialog();
                }
                else if (role == "technician")
                {
                    TechnicianHome b = new TechnicianHome(un);
                    b.ShowDialog();
                }
                else if (role == "admin")
                {
                    MainMenu c = new MainMenu();
                    c.ShowDialog();
                }


                else if (role == "customer")
                {
                    frmCustomer d = new frmCustomer();
                    d.ShowDialog();
                }


                }
                else
                    status = "Incorrect username/password";
            con.Close();

            return status;


        }
    }
}
        


    

