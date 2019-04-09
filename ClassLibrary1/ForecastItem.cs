using System;

namespace Data
{
    public class ForecastItem
    {
        private string _city;
        private DateTime _date;
        private double _precipitation;
        private double _humidity;
        private double _windSpeed;
        private double _minTemp;
        private double _maxTemp;

        public ForecastItem(string city, DateTime date, double precipitation, double humidity, double windspeed, double mintemp, double maxtemp)
        {
            this.City = city;
            this.Date = date;
            this.Precipitation = precipitation;
            this.Humidity = humidity;
            this.WindSpeed = windspeed;
            this.MinTemp = mintemp;
            this.MaxTemp = maxtemp;
        }

        public string City { get => _city; set => _city = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public double Precipitation { get => _precipitation; set => _precipitation = value; }
        public double Humidity { get => _humidity; set => _humidity = value; }
        public double WindSpeed { get => _windSpeed; set => _windSpeed = value; }

        public double MinTemp { get => _minTemp; set => _minTemp = value; }
        public double MaxTemp { get => _maxTemp; set => _maxTemp = value; }

    }
}
