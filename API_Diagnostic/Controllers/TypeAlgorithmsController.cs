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

namespace API_Diagnostic.Controllers
{
    public class TypeAlgorithmsController : ApiController
    {
        private DiagServiceContext db = new DiagServiceContext();

        // GET: api/TypeAlgorithms
        /// <summary>
        /// Список типов алгоритмов
        /// </summary>
        /// <returns>Dictionary(id_typeAlgoriths, name_typeAlgoriths)</returns>
        public IHttpActionResult GetTypeAlgorithms()
        {
            //db.TypeAlgorithms;
            Dictionary<int, string> typeAlgoriths = new Dictionary<int, string>();
            try
            {
                foreach (var t in db?.TypeAlgorithms)
                {
                    typeAlgoriths.Add(t.Id, t.Name);
                }
                if (typeAlgoriths.Count == 0)
                {
                    return NotFound();
                }
                else
                {
                    return Json(typeAlgoriths);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/TypeAlgorithms/5
        /// <summary>
        /// Название TypeAlgorithm по его id
        /// </summary>
        /// <param name="id">id TypeAlgorithm</param>
        /// <returns>Ok(typeAlgorithm.Name)</returns>
        [ResponseType(typeof(TypeAlgorithm))]
        public async Task<IHttpActionResult> GetTypeAlgorithm(int id)
        {
            TypeAlgorithm typeAlgorithm = await db.TypeAlgorithms.FindAsync(id);
            if (typeAlgorithm == null)
            {
                return NotFound();
            }
            return Ok(typeAlgorithm.Name);
        }

       // PUT: api/TypeAlgorithms/5
       // [ResponseType(typeof(void))]
       // public async Task<IHttpActionResult> PutTypeAlgorithm(int id, TypeAlgorithm typeAlgorithm)
       // {
       //     if (!ModelState.IsValid)
       //     {
       //         return BadRequest(ModelState);
       //     }

       //     if (id != typeAlgorithm.Id)
       //     {
       //         return BadRequest();
       //     }

       //     db.Entry(typeAlgorithm).State = EntityState.Modified;

       //     try
       //     {
       //         await db.SaveChangesAsync();
       //     }
       //     catch (DbUpdateConcurrencyException)
       //     {
       //         if (!TypeAlgorithmExists(id))
       //         {
       //             return NotFound();
       //         }
       //         else
       //         {
       //             throw;
       //         }
       //     }

       //     return StatusCode(HttpStatusCode.NoContent);
       // }

       // POST: api/TypeAlgorithms
       //[ResponseType(typeof(TypeAlgorithm))]
       // public async Task<IHttpActionResult> PostTypeAlgorithm(TypeAlgorithm typeAlgorithm)
       // {
       //     if (!ModelState.IsValid)
       //     {
       //         return BadRequest(ModelState);
       //     }

       //     db.TypeAlgorithms.Add(typeAlgorithm);
       //     await db.SaveChangesAsync();

       //     return CreatedAtRoute("DefaultApi", new { id = typeAlgorithm.Id }, typeAlgorithm);
       // }

       // DELETE: api/TypeAlgorithms/5
       // [ResponseType(typeof(TypeAlgorithm))]
       // public async Task<IHttpActionResult> DeleteTypeAlgorithm(int id)
       // {
       //     TypeAlgorithm typeAlgorithm = await db.TypeAlgorithms.FindAsync(id);
       //     if (typeAlgorithm == null)
       //     {
       //         return NotFound();
       //     }

       //     db.TypeAlgorithms.Remove(typeAlgorithm);
       //     await db.SaveChangesAsync();

       //     return Ok(typeAlgorithm);
       // }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TypeAlgorithmExists(int id)
        {
            return db.TypeAlgorithms.Count(e => e.Id == id) > 0;
        }
    }
}