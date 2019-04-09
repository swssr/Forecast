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
        public SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\simo\Documents\forecasts.mdf;Integrated Security=True;Connect Timeout=30");
        List<Forecast> Forecasts = new List<Forecast>();

        public void bindDropDown(ComboBox cmb)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select City from Forecast";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmb.DataSource = dt;
            cmd.ExecuteNonQuery();
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

            //Also, bind all combo boxes
        }
        public void cityForecastBy(int? range, DataGridView dataGridView, MetroTextBox txtBox)
        {
            //TODO: Use interfaces, encapsulate ff function.
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //Fetch based specified date range, define default behavior 
            cmd.CommandText = "select * from Forecast where City='" + txtBox.Text+ "'";
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
