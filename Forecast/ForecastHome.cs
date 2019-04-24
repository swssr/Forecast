using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forecast
{
    public partial class ForecastHome : Form
    {
        public ForecastHome()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            ForecastHome home = new ForecastHome();
            home.Visible = false;
            this.Hide();

            using (LoginForm login = new LoginForm())
            {
                login.ShowDialog();
            }
        }
    }
}
