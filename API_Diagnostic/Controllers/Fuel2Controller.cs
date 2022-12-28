using API_Diagnostic.Database;
using Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_Diagnostic.Controllers
{
    public class Fuel2Controller : ApiController
    {
        private DiagServiceContext db = new DiagServiceContext();

        //[Route("api/Section/Fuel")]
        // GET: api/Section/Fuel?notation="2ТЭ25КМ-448А"
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

        //[Route("api/Section/Fuel")]
        // GET: api/Section/Fuel/5 
        public IHttpActionResult GetFuelSection(int id)
        {
            Section section = db.Sections.Where(s => s.RefID == id).First();
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
    }
}
