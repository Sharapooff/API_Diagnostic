using API_Diagnostic.Database;
using API_Diagnostic.Models.ResultModels;
using Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace API_Diagnostic.Controllers
{
    public class FuelController : ApiController
    {
        private DiagServiceContext db = new DiagServiceContext();

        // GET: api/Fuel        
        public IHttpActionResult GetFuelSection(string notation)
        {
            Section section = db.Sections.Where(s => s.Notation == notation).First();
            if (section == null)
            {
                return NotFound();
            }
            try
            {
                var fuelInfo = db.GetSectionFuelNow(section.RefID.Value).First();
                return Ok(fuelInfo);
            }
            catch
            {
                return BadRequest();
            }            
        }

        // GET: api/Fuel/5
        public async Task<IHttpActionResult> GetFuelSections()
        
        {
            List<SectionFuelNowInfo> result = new List<SectionFuelNowInfo>();
            List<string> result2 = new List<string>();

            var sections = db.Sections.ToList();
            if (sections.Count == 0)
            {
                return NotFound();
            }
            SectionFuelNowInfo record;
            foreach (var s in sections)
            {
                try
                {
                    record = new SectionFuelNowInfo(); var _record = await db.GetSectionFuelNowAsync(s.RefID.Value);
                    if (_record != null)
                    {
                        record = _record.First();
                        result.Add(record);
                    }
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                }
            }
            //if (result2.Count > 0)
            return Ok(result);
        }

    }
}
