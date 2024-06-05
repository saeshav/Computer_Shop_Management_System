using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace group3assignment
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
            List<ServiceFee> ft = new List<ServiceFee>();
            ft.Add(new ServiceFee() {price=50,service=" Remove virus, malware or spyware - Normal " });
            ft.Add(new ServiceFee() { price = 80, service = " Remove virus, malware or spyware - Urgent " });
            ft.Add(new ServiceFee() { price = 60, service = " Troubleshoot and fix computer running slow - Normal " });
            ft.Add(new ServiceFee() { price = 90, service = " Troubleshoot and fix computer running slow - Urgent " });
            ft.Add(new ServiceFee() { price = 380, service = " Laptop screen replacement - Normal " });
            ft.Add(new ServiceFee() { price = 430, service = " Laptop screen replacement - Urgent " });
            ft.Add(new ServiceFee() { price = 160, service = " Laptop Keyboard replacement - Normal " });
            ft.Add(new ServiceFee() { price = 200, service = " Laptop Keyboard replacement - Urgent " });
            ft.Add(new ServiceFee() { price = 180, service = " Laptop Battery replacement - Normal " });
            ft.Add(new ServiceFee() { price = 210, service = " Laptop Battery replacement - Urgent " });
            ft.Add(new ServiceFee() { price = 210, service = " Laptop Battery replacement - Urgent " });
            ft.Add(new ServiceFee() { price = 100, service = " Operating System Format and Installation - Normal " });
            ft.Add(new ServiceFee() { price = 150, service = " Operating System Format and Installation - Urgent " });
            ft.Add(new ServiceFee() { price = 80, service = " Data backup and Recovery - Normal " });
            ft.Add(new ServiceFee() { price = 130, service = " Data backup and Recovery - Urgent " });
            ft.Add(new ServiceFee() { price = 70, service = " Internet Connectivity issues - Normal " });
            ft.Add(new ServiceFee() { price = 100, service = " Internet Connectivity issues - urgent " });
            cmbType.DataSource = ft;
            cmbType.DisplayMember = "service";




        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Customer obj1 = new Customer(txtCname.Text, txtCemail.Text, txtPhoneNumber.Text, cmbType.Text, txtAmount.Text, cmbStatus.Text);
            MessageBox.Show(obj1.AddCustomer());
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void txtCname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceFee ft1 = cmbType.SelectedItem as ServiceFee;
            txtAmount.Text = Convert.ToString (ft1.price);
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
