using group3assignment.Admin;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnRegisterTec_Click(object sender, EventArgs e)
        {
            technicaianRegister form = new technicaianRegister();
            form.ShowDialog();
        }

        private void btnRegisterRec_Click(object sender, EventArgs e)
        {
            receptionistRegistration form = new receptionistRegistration();
            form.ShowDialog();
        }

        private void btnViewIncome_Click(object sender, EventArgs e)
        {
            viewTotalMonthIncome form = new viewTotalMonthIncome();
            form.ShowDialog();
        }

        private void btnViewService_Click(object sender, EventArgs e)
        {
            MonthlyReport form = new MonthlyReport();
            form.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
