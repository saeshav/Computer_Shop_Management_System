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
    public partial class ReceptionistHome : Form
    {
        public static string name;
        public ReceptionistHome(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void ReceptionistHome_Load(object sender, EventArgs e)
        {
            lblIdentity.Text = "hello," + name;

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddCustomer ad = new AddCustomer();
            ad.ShowDialog();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payment ad = new Payment();
            ad.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_Profile ad = new Update_Profile(name);
            ad.ShowDialog();
        }

        private void lblIdentity_Click(object sender, EventArgs e)
        {

        }
    }
}
