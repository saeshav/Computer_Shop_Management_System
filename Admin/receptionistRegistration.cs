using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group3assignment
{
    public partial class receptionistRegistration : Form
    {
        public receptionistRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string password2 = txtPassword2.Text;
            string name = txtName.Text;
            string email = txtEmail.Text;
            string contact = txtContactNumber.Text;

            bool flag1 = true;
            bool flag2 = true;
            bool flag3 = true;
            bool flag4 = true;
            bool flag5 = true;

            if (username == "")
            {
                flag1 = false;
                MessageBox.Show("Please Fill in Username");
            }
            else if (name == "")
            {
                flag2 = false;
                MessageBox.Show("Please Fill in Name");
            }
            else if (email == "")
            {
                flag3 = false;
                MessageBox.Show("Please Fill in Email");
            }
            else if (contact == "")
            {
                flag4 = false;
                MessageBox.Show("Please Fill in Contact");
            }


            if (password == password2)
            {
                flag5 = true;
            }
            else
            {
                flag5 = false;
                MessageBox.Show("Please make sure your password is the same.");
            }

            if (flag1 == true && flag2 == true && flag3 == true && flag4 == true && flag5 == true)
            {
                register register = new register(username, password, name, email, contact);
                register.register_role("receptionist");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void receptionistRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
