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

namespace API_Diagnostic.Controllers
{
    public class AlgoritmsController : ApiController
    {
        private DiagServiceContext db = new DiagServiceContext();

        // GET: api/Algoritms
        /// <summary>
        /// Метод возвращает словарь - id-Name всех алгоритмов диагностирования
        /// </summary>
        /// <returns>Dictionary(id_algorithm name_algorithm)</returns>
        public IHttpActionResult GetAlgoritms()
        {
            Dictionary<int, string> algoriths = new Dictionary<int, string>();
            try
            {
                foreach (var a in db?.Algoritms)
                {
                    algoriths.Add(a.Id, a.Name);
                }
                if (algoriths.Count == 0)
                {
                    return NotFound();
                }
                else
                {
                    return Json(algoriths);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Algoritms/5
        /// <summary>
        /// Метод возвращает Name алгоритма диагностирования по его id
        /// </summary>
        /// <param name="id">id алгоритма диагностировангия</param>
        /// <returns>Название алгоритма</returns>
        public IHttpActionResult GetAlgoritm(int id)
        {
            Algoritm algoritm = db.Algoritms.Find(id);
            if (algoritm == null)
            {
                return NotFound();
            }
            return Ok(algoritm.Name);
        }

        // PUT: api/Algoritms/5

        /// <summary>
        /// Изменить алгоритм
        /// </summary>
        /// <param name="id">id алгоритма</param>
        /// <param name="algoritm">Измененный объект алгоритма</param>
        /// <returns>void</returns>
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAlgoritm(int id, Algoritm algoritm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != algoritm.Id)
            {
                return BadRequest();
            }

            db.Entry(algoritm).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlgoritmExists(id))
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

        // POST: api/Algoritms
        /// <summary>
        /// Добавление нового алгоритма
        /// </summary>
        /// <param name="algoritm">Добовлемый объект алгоритма</param>
        /// <returns>CreatedAtRoute("DefaultApi", new { id = algoritm.Id }, algoritm)</returns>
        [ResponseType(typeof(Algoritm))]        
        public IHttpActionResult PostAlgoritm(Algoritm algoritm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Algoritms.Add(algoritm);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = algoritm.Id }, algoritm);
        }

        // DELETE: api/Algoritms/5
        /// <summary>
        /// Удаление алгоритма
        /// </summary>
        /// <param name="id">id флгоритма</param>
        /// <returns>Ok(algoritm)</returns>
        [ResponseType(typeof(Algoritm))]
        public IHttpActionResult DeleteAlgoritm(int id)
        {
            Algoritm algoritm = db.Algoritms.Find(id);
            if (algoritm == null)
            {
                return NotFound();
            }

            db.Algoritms.Remove(algoritm);
            db.SaveChanges();

            return Ok(algoritm);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AlgoritmExists(int id)
        {
            return db.Algoritms.Count(e => e.Id == id) > 0;
        }
    }
}