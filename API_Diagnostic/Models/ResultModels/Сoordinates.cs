using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Diagnostic.Models.ResultModels
{
    public class Сoordinates
    {
        public DateTime? max_dt { get; set; } 
        public double? lat { get; set; }
        public double? lng { get; set; }

        public void Coordinates()
        {

        }

        public void Coordinates(DateTime max_dt, double latitude, double longitude)
        {
            this.max_dt = max_dt;
            lat = latitude;
            lng = longitude;
        }
    }
}