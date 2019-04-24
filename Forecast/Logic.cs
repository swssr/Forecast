using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forecast
{
    public class Logic
    {
        //public SqlConnection connection = new SqlConnection(@"Data Source=|DataDirectory|\forecasts.mdf;Integrated Security=True;Connect Timeout=30");

        public SqlConnection connection = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\forecasts.mdf;Integrated Security=True;Connect Timeout=30");
        List<Forecast> Forecasts = new List<Forecast>();    

        public void bindDropDown(ComboBox cmb)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select City from Forecast";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlDataReader dr = cmd.ExecuteReader();

            cmb.Items.Clear();

            IList<string> listCities = new List<string>();

            while (dr.Read())
            {
                listCities.Add(dr[0].ToString());
            }
            listCities = listCities.Distinct().OrderBy(c => c).ToList();
            listCities.Insert(0, "Select City");

            //da.Fill(dt);
            cmb.DataSource = listCities;
            cmb.SelectedIndex = 0;
            //cmd.ExecuteNonQuery();

            connection.Close();

        }
        public void getAllData(DataGridView gridView)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Forecast";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            gridView.DataSource = dt;
            cmd.ExecuteNonQuery();
            connection.Close();

        }
        public void cityForecastBy(DataGridView dataGridView, String city, int? range)
        {
                //TODO: Use interfaces, implement ff function.
                //Working from ApplicationContext is less expensive, use DbEntity
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //TODO: Fetch based specified date range, define default behavior
                cmd.CommandText = $"select * from Forecast where City='{city}'";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView.DataSource = dt;
                cmd.ExecuteNonQuery();
                connection.Close();
        }
        public string getVal(ScrollEventArgs e) => (e.NewValue).ToString();

    }
}
