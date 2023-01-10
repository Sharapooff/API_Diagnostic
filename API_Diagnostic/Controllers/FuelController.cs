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

        // GET: api/Fuel?id=5       
        /// <summary>
        /// Уровень топлива секции на текущий момент, по ее id 
        /// </summary>
        /// <param name="id">id секции</param>
        /// <returns>Масса топлива в кг.</returns>
        [HttpGet]
        [Route("api/Section/FuelNow")]
        public async Task<IHttpActionResult> FuelSection(int id)
        {
            Section section = db.Sections.Where(s => s.Id == id).First();
            if (section == null)
            {
                return NotFound();
            }
            try
            {
                return Ok((await db.GetSectionFuelNowAsync(section.RefID.Value)).First());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // GET: api/Fuel?notation="2ТЭ25КМ-448А"   
        /// <summary>
        /// Уровень топлива секции на текущий момент, по ее полному названию
        /// </summary>
        /// <param name="notation">полное название секции</param>
        /// <returns>Масса топлива в кг.</returns>
        [HttpGet]
        [Route("api/Section/FuelNow")]
        public async Task<IHttpActionResult> FuelSection(string notation)
        {
            Section section = db.Sections.Where(s => s.Notation == notation).First();
            if (section == null)
            {
                return NotFound();
            }
            try
            {
                return Ok((await db.GetSectionFuelNowAsync(section.RefID.Value)).First());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }            
        }

        // GET: api/Fuel
        /// <summary>
        /// Список всех секций с массой топлива в кг.
        /// </summary>
        /// <returns>Список всех секций с массой топлива в кг.</returns>
        [NonAction]
        [HttpGet]
        public async Task<IHttpActionResult> FuelSections()        
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
                    return BadRequest(ex.Message);
                }
            }
            //if (result2.Count > 0)
            return Ok(result);
        }

    }
}
