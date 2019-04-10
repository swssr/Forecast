using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Forecast
{
    public partial class RainCheck : MetroFramework.Forms.MetroForm
    {
        Logic logic = new Logic();

        public RainCheck()
        {
            InitializeComponent();
        }

        private void RainCheck_Load(object sender, EventArgs e)
        {
            logic.getAllData(dataGridView1);
            logic.bindDropDown(ddlCities);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            logic.connection.Open();
            SqlCommand cmd = logic.connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //TODO: lookup best ways of doing this . string intoerpolation ✔ and dbEntity;
            //cmd.CommandText = "insert into Forecast values('Cape Town','10-10-20', '20', '20', '20', '20', '20')";
            string cmdString = $"insert into Forecast values('{txtCity.Text}','{dateTimePicker1.Value}', '{txtMinTemp.Text}', '{txtMaxTemp.Text}', '{trkPrecip.Value}', '{int.Parse(txtHumidity.Text)}', '{int.Parse(txtWindSpeed.Text)}')";
            cmd.CommandText = cmdString;

            cmd.ExecuteNonQuery();
            logic.connection.Close();

            MessageBox.Show("New Record added Successfully");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void trkMinTemp_Scroll(object sender, ScrollEventArgs e) => txtMinTemp.Text = logic.getVal(e);

        private void trkMaxTemp_Scroll(object sender, ScrollEventArgs e) => txtMaxTemp.Text = logic.getVal(e);

        private void trkPrecip_Scroll(object sender, ScrollEventArgs e) => txtPrecip.Text = logic.getVal(e);



        private void metroTile1_Click(object sender, EventArgs e)
        {
            using (Search_City sc = new Search_City())
            {
                sc.ShowDialog();
            }
        }

      


        private void ddlCities_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                string city = ddlCities.SelectedValue.ToString();
                logic.cityForecastBy(gridPrevUp, city, null);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Record Not Found /n {error} form Update form");
            }

        }

        //Unused
        private void tabDelete_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }
        private void metroTabPage2_Click(object sender, EventArgs e)
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

        private void metroTile1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            logic.getAllData(dataGridView1);
        }

        private void gridPreview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelCity_Click(object sender, EventArgs e)
        {

        }

        private void txtDelCity_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
