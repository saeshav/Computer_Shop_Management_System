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
    public partial class TechnicianHome : Form
    {
        public static string name;
        public TechnicianHome()
        {
            InitializeComponent();
            
        }
        public TechnicianHome(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void TechnicianHome_Load(object sender, EventArgs e)
        {
            lblName.Text = "Hello," + name;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void View_Click(object sender, EventArgs e)
        {
            ViewService vs = new ViewService();
            vs.ShowDialog();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddDescription ad = new AddDescription();
            ad.ShowDialog();
        }

        private void update_Click(object sender, EventArgs e)
        {
            UpdateTechnician up = new UpdateTechnician(name);
            up.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(" Are you sure want to logout now?",
                "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    this.Close();
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
