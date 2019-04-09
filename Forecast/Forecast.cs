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
        public int Id { get; set; }
        public String City { get; set; }
        public String Date { get; set; }
        public int Mintemp { get; set; }
        public int Maxtemp { get; set; }
        public int Precip { get; set; }
        public int Humidity { get; set; }
        public int Windspeed { get; set; }

    }
}
