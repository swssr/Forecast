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

        public Forecast ForecastData { get { return bindingSource1.Current as Forecast; } }
        private void RainCheck_Load(object sender, EventArgs e)
        {

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string getVal(ScrollEventArgs e) => (e.NewValue).ToString();

        private void trkMinTemp_Scroll(object sender, ScrollEventArgs e)
        {
            txtMinTemp.Text = getVal(e);
        }

        private void trkMaxTemp_Scroll(object sender, ScrollEventArgs e)
        {
            txtMaxTemp.Text = getVal(e);
        }

        private void trkPrecip_Scroll(object sender, ScrollEventArgs e)
        {
            txtPrecip.Text = getVal(e);

        }
         
        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            using (Search_City sc = new Search_City())
            {
                sc.ShowDialog();
            }
        }
    }
}
