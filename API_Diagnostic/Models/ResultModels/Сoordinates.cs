using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Diagnostic.Models.ResultModels
{
    public class Сoordinates
    {
        public double? latitude { get; set; }
        public double? longitude { get; set; }

        public void Coordinates()
        {

        }

        public void Coordinates(double Latitude, double Longitude)
        {
            this.latitude = Latitude;
            this.longitude = longitude;
        }
    }
}