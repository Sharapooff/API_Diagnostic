using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Diagnostic.Models.ResultModels
{
    public class SectionMaxDateTime
    {
        public string Notation { get; set; }
        public int? Number { get; set; }
        public string Section { get; set; }
        public int? SectionID { get; set; }        
        public DateTime maxDT { get; set; }

        SectionMaxDateTime() { }
        SectionMaxDateTime(DateTime maxDT, int sectionId , string section, int number, string notation)
        {
            this.maxDT = maxDT;
            this.Notation = notation;
            this.Number = number;
            this.Section = section;
            this.SectionID = sectionId;
        }
    }
}