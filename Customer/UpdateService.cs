using group3assignment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group3assignment
{
    public partial class UpdateService : Form
    {
        private static string name;

        public UpdateService()
        {
            InitializeComponent();
        }
        
        

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            

            

                txtServiceId.BackColor = System.Drawing.Color.White;
                cboService.BackColor = System.Drawing.Color.White;
                
                UpdateRequest obj1 = new UpdateRequest(name);
                MessageBox.Show(obj1.UpdateService(txtServiceId.Text, cboService.Text));
                this.Close();

        }
            
                

        

        private void txtServiceID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}