using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using API_Diagnostic.Database;
using Models.DataBase;

//https://learn.microsoft.com/ru-ru/aspnet/web-api/overview/getting-started-with-aspnet-web-api/creating-api-help-pages

namespace API_Diagnostic.Controllers
{
    public class SectionController : ApiController
    {
        private DiagServiceContext db = new DiagServiceContext();

        // GET: api/Sections
        /// <summary>
        /// Cписок секций, id и полное наименование.
        /// </summary>
        /// <returns>Словарь в формате json в случае удачного запроса, BadRequest(ex.Message) в случае наличия ошибки</returns>
        [HttpGet]
        [Route("api/Sections")]
        public IHttpActionResult GetSections()
        {
            Dictionary<int, string> result = new Dictionary<int, string>();
            try
            {
                foreach (var s in db?.Sections)
                {
                    result.Add(s.Id, s.Notation);
                }
                if (result.Count == 0)
                {
                    return NotFound();
                }
                else
                {
                    return Json(result);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Sections/5 or api/Sections/?id=5
        /// <summary>
        /// Полное наименование секции по ее id.
        /// </summary>
        /// <param name="id">id сенкции</param>
        /// <returns>Полное наиенование секции (2ТЭ25КМ-446А).</returns>
        public async Task<IHttpActionResult> GetSection(int id)
        {
            try
            {
                Section section = await db?.Sections.FindAsync(id);
                if (section == null)
                {
                    return NotFound();
                }
                return Ok(section.Notation);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Section/2ТЭ25КМ-443А
        /// <summary>
        /// Id секции по ее полному наименованию.
        /// </summary>
        /// <param name="notation">Полное наименование секции (2ТЭ25КМ-446А).</param>
        /// <returns></returns>
        public async Task<IHttpActionResult> GetSection(string notation)
        {
            try
            {
                Section section = await db.Sections.Where(s => s.Notation == notation).FirstAsync();
                if (section == null)
                {
                    return NotFound();
                }
                return Ok(section.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }                      
    }
}