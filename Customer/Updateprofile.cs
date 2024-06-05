using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group3assignment
{
    public partial class UpdateProfile : Form
    {
        private static string name;

        public UpdateProfile()
        {
            InitializeComponent();
        }


        public class CheckEmail
        {
            public static bool CheckForEmail(String email)
            {
                bool IsValid = false;
                Regex r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (r.IsMatch(email))
                    IsValid = true;
                return IsValid;
            }
        }
        public class CheckNumber
        {


            public static bool CheckForNumber(String number)
            {
                bool IsValid = false;
                Regex r = new Regex(@"^[0-9]{10}$");
                if (r.IsMatch(number))
                    IsValid = true;
                return IsValid;
            }
        }

         private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckEmail.CheckForEmail(txtEmail.Text.ToString()) && (CheckNumber.CheckForNumber(txtNumber.Text.ToString())))
            {
                txtEmail.BackColor = System.Drawing.Color.White;
                txtNumber.BackColor = System.Drawing.Color.White;
                MessageBox.Show("Data is valid");
                Customers obj1 = new Customers(name);
                MessageBox.Show(obj1.UpdateCustomer(txtName.Text, txtEmail.Text, txtNumber.Text));
                this.Close();

            }
            else
                MessageBox.Show("Data is invalid");

        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
