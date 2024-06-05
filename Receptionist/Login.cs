namespace group3assignment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string stat;
            User obj1 = new User(txtUsername.Text, txtPassword.Text);
            stat = obj1.Login(txtUsername.Text);
            if (stat != null)
            {
                MessageBox.Show(stat);

            }
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbshow.Checked==true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}