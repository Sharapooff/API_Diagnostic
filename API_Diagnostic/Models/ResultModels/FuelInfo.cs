using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Diagnostic.Models.ResultModels
{
    /// <summary>
    /// Класс результата хранимой процедуры, возращающий максимальную дату и количество топлива
    /// </summary>
    public class SectionFuelNowInfo
    {
        public DateTime? max_dt { get; set; }
        public int? fuel { get; set; }

        public SectionFuelNowInfo()
        { }
        public SectionFuelNowInfo(DateTime Max_dt, int Fuel)
        {
            this.max_dt = Max_dt;
            this.fuel = Fuel;
        }
    }

    
}