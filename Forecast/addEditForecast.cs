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
    public partial class addEditForecast : MetroFramework.Forms.MetroForm
    {
        public addEditForecast()
        {
            InitializeComponent();
        }

        private void addEditForecast_Load(object sender, EventArgs e)
        {

        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
