using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forecast
{
    public partial class Search_City : MetroFramework.Forms.MetroForm
    {
        Logic logic = new Logic();

        public Search_City()
        {
            InitializeComponent();
        }

        private void Search_City_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public string dateRange()
        {
            string output = "";

            return output;
        }
        private void txtSearchCity_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void bgPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trkRange_Scroll(object sender, ScrollEventArgs e) => txtRange.Text = logic.getVal(e);

        private void button1_Click(object sender, EventArgs e)
        {
            logic.cityForecastBy(2, grdCityForecast, txtSearchCity);
        }
    }
}
