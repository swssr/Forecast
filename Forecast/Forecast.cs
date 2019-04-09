using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast
{
    public class Forecast
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("city")]
        public String City { get; set; }
        [BsonElement("date")]
        public String Date { get; set; }
        [BsonElement("mintemp")]
        public double Mintemp { get; set; }
        [BsonElement("maxtemp")]
        public double Maxtemp { get; set; }
        [BsonElement("precip")]
        public double Precip { get; set; }
        [BsonElement("humidity")]
        public double Humidity { get; set; }
        [BsonElement("windspeed")]
        public double Windspeed { get; set; }

        public Forecast(string city, string date, double mintemp, double maxtemp, double precip, double humidity, double windspeed)
        {
            City = city;
            Date = date;
            Mintemp = mintemp;
            Maxtemp = maxtemp;
            Precip = precip;
            Humidity = humidity;
            Windspeed = windspeed;
        }
    }
}
