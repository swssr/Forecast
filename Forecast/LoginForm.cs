using System;
using System.Windows.Forms;

namespace Forecast
{
    public partial class LoginForm : Form
    {
        Login login = new Login("admin", "Password01");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (login.isLoggedIn(username, password))
            {
                this.Visible = false;
                this.Hide();

                RainCheck dashboard = new RainCheck();

                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Failed to login");
            }

        }

    }
}
