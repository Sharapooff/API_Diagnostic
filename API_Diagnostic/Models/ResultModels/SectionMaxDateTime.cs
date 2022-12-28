using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Diagnostic.Models.ResultModels
{
    public class SectionMaxDateTime
    {       
        public DateTime maxDT { get; set; }

        public SectionMaxDateTime() { }
        public SectionMaxDateTime(DateTime maxDT)
        {
            this.maxDT = maxDT;
        }
    }
}