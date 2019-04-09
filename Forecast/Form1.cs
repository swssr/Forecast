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
    public partial class RainCheck : MetroFramework.Forms.MetroForm
    {
        public RainCheck()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            using(addEditForecast form = new addEditForecast())
            {
                form.ShowDialog();
            }
        }
    }
}
