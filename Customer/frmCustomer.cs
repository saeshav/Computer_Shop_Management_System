using group3assignment;
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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(" ARE YOU SURE YOU WANT TO LOG OUT?", "CONFIRM LOG OUT",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    this.Close();
                    break;
                case DialogResult.No:
                    break;
            }

        }

        private void btnService_Click_1(object sender, EventArgs e)
        {
            UpdateService us = new UpdateService();
            us.ShowDialog();

        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            UpdateProfile up = new UpdateProfile();
            up.ShowDialog();

        }

        private void btnDescription_Click_1(object sender, EventArgs e)
        {
            ViewDescriptionDateAmount vd = new ViewDescriptionDateAmount();
            vd.ShowDialog();

        }
    }
}
