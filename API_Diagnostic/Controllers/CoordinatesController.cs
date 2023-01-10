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
    public class CoordinatesController : ApiController
    {
        private DiagServiceContext db = new DiagServiceContext();

        //Местоположение секции по максимальной дате и ее названию

        // GET: api/Section/Coordinates/5
        /// <summary>
        /// Местоположение (координаты) секции по ее Id
        /// </summary>
        /// <param name="id">Id секции</param>
        /// <returns>Дата и координаты местопложения, соответствующие последней зафиксированной в БД</returns>
        [HttpGet]
        [Route("api/Section/CoordinatesNow")]
        public async Task<IHttpActionResult> CoordinatesNow(int id)
        {
            Section section = db.Sections.Where(s => s.Id == id).First();
            if (section == null)
            {
                return NotFound();
            }
            try
            {
                return Ok((await db.GetSectionСoordinatesAsync(section.RefID.Value)).First());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Section/Coordinates?notation="notation"
        /// <summary>
        /// Местоположение (координаты) секции по ее полному названию
        /// </summary>
        /// <param name="notation">Полное наименование секции</param>
        /// <returns>Дата и координаты местопложения, соответствующие последней зафиксированной в БД</returns>
        [HttpGet]
        [Route("api/Section/CoordinatesNow")]
        public async Task<IHttpActionResult> CoordinatesNow(string notation)
        {
            Section section = db.Sections.Where(s => s.Notation == notation).First();
            if (section == null)
            {
                return NotFound();
            }
            try
            {
                return Ok((await db.GetSectionСoordinatesAsync(section.RefID.Value)).First());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
