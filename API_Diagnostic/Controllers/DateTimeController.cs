using API_Diagnostic.Database;
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

    public class DateTimeController : ApiController
    {
        private DiagServiceContext db = new DiagServiceContext();
        
        /// <summary>
        /// Дата и время последней регистрации данных о секции локомотива по ее ID
        /// </summary>
        /// <param name="id">Id  секции</param>
        /// <returns>Полное название секции и дату/время поледней регистрации данных</returns>
        // GET: api/DateTime
        [HttpGet]
        [Route("api/Section/MaxDateTime")]
        public async Task<IHttpActionResult> GetMaxDateTime(int id)
        {
            Section section = db.Sections.Where(s => s.Id == id).First();
            if (section == null)
            {
                return NotFound();
            }
            try
            {
                return Ok((await db.GetSectionMaxDateTimeAsync(section.RefID.Value)).First());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Дата и время последней регистрации данных о секции локомотива по ее полному наименованию
        /// </summary>
        /// <param name="notation">Полное неименование секции</param>
        /// <returns>Полное название секции и дату/время поледней регистрации данных</returns>
        [HttpGet]
        [Route("api/Section/MaxDateTime")]
        public async Task<IHttpActionResult> CoordinatesNow(string notation)
        {
            Section section = db.Sections.Where(s => s.Notation == notation).First();
            if (section == null)
            {
                return NotFound();
            }
            try
            {
                return Ok((await db.GetSectionMaxDateTimeAsync(section.RefID.Value)).First());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
