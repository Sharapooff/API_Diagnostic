using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using API_Diagnostic.Database;
using Models.DataBase;

//https://learn.microsoft.com/ru-ru/aspnet/web-api/overview/getting-started-with-aspnet-web-api/creating-api-help-pages

namespace API_Diagnostic.Controllers
{
    public class SectionsController : ApiController
    {
        private DiagServiceContext db = new DiagServiceContext();

        // GET: api/Sections
        /// <summary>
        /// Метод возвращает словарь, в виде ключ-значение, где ключ - id секции, а значение - ее полное наименование, для всех секций в таблице Sections.
        /// </summary>
        /// <returns>Dictionary<int, string> в формате json в случае удачного запроса и BadRequest(ex.Message) в случае наличия ошибки.</returns>
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
        /// Метод возврващает полное наименование секции по ее id.
        /// </summary>
        /// <param name="id">id сенкции</param>
        /// <returns>Полное наиенование секции (2ТЭ25КМ-446А).</returns>
        public IHttpActionResult GetSection(int id)
        {
            Section section = db.Sections.Find(id);
            if (section == null)
            {
                return NotFound();
            }
            return Ok(section.Notation);
        }

        // GET: api/Sections/2ТЭ25КМ-443А
        /// <summary>
        /// Метод возвращает id секции по ее полному наименованию.
        /// </summary>
        /// <param name="notation">Полное наименование секции (2ТЭ25КМ-446А).</param>
        /// <returns></returns>
        public IHttpActionResult GetSection(string notation)
        {
            Section section = db.Sections.Where(s=>s.Notation == notation).First();
            if (section == null)
            {
                return NotFound();
            }
            return Ok(section.Id);
        }


        // PUT: api/Sections/5
        [ResponseType(typeof(void))]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IHttpActionResult PutSection(int id, Section section)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != section.Id)
            {
                return BadRequest();
            }

            db.Entry(section).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SectionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Sections
        [ResponseType(typeof(Section))]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IHttpActionResult PostSection(Section section)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sections.Add(section);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = section.Id }, section);
        }

        // DELETE: api/Sections/5
        [ResponseType(typeof(Section))]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IHttpActionResult DeleteSection(int id)
        {
            Section section = db.Sections.Find(id);
            if (section == null)
            {
                return NotFound();
            }

            db.Sections.Remove(section);
            db.SaveChanges();

            return Ok(section);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SectionExists(int id)
        {
            return db.Sections.Count(e => e.Id == id) > 0;
        }
    }
}