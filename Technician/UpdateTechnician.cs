using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace group3assignment
{
    public partial class UpdateTechnician : Form
    {

        public static string name;
        
        

        public UpdateTechnician(string n)
        {
            InitializeComponent();
            name = n;
        }
        

        

        private void UpdateTechnician_Load(object sender, EventArgs e)
        {
            Technician obj1 = new Technician(name);

            Technician.viewProfile(obj1);

            txtname.Text = name;
            txtemail.Text = obj1.Email;
            txtnumber.Text = obj1.PhoneNum;

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



        private void Update_Click(object sender, EventArgs e)

        {
            
            if (CheckEmail.CheckForEmail(txtemail.Text.ToString())&&(CheckNumber.CheckForNumber(txtnumber.Text.ToString())))
            {
                

                txtemail.BackColor = System.Drawing.Color.LightGreen;
                txtnumber.BackColor = System.Drawing.Color.LightGreen;
                MessageBox.Show("Data is valid");
                Technician obj1 = new Technician(name);
                MessageBox.Show(obj1.UpdateTechnician(txtname.Text,txtemail.Text, txtnumber.Text));
                this.Close();
               
            }

            else
            
           MessageBox.Show("Data is invalid");
            

            

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
