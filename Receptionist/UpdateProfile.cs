using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group3assignment
{
    public partial class Update_Profile : Form
    {
        public static string name;

        public Update_Profile(string m)
        {
            InitializeComponent();
            name = m;
            
        }

        private void Update_Profile_Load(object sender, EventArgs e)
        {
            Recep obj2 = new Recep(name);

            Recep.viewProfile(obj2);

            txtname.Text = name;
            txtMail.Text = obj2.Email;
            txtNumber.Text = obj2.Number;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Recep obj1 = new Recep(name);
            MessageBox.Show(obj1.UpdateProfile(txtname.Text, txtMail.Text, txtNumber.Text));
        }

        private void txtRecep_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
