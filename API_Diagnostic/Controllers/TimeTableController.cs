using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

using API_Diagnostic.Database;
using Models.DataBase;

namespace API_Diagnostic.Controllers
{

    //[Authorize]
    public class TimeTableController : ApiController
    {
        private DiagServiceContext db = new DiagServiceContext();

        /// <summary>
        /// Метод возвращает полное название секции локомотива и название алгоритма по всем записям в таблице расписания.
        /// </summary>
        /// <returns>Словарь: полное название секции локомотива - название алгоритма</returns>
        // GET: api/TimeTable
        public IHttpActionResult Get()
        {
            Dictionary<int, string> typeAlgoriths = new Dictionary<int, string>();
            try
            {
                foreach (var t in db?.TimeTables)
                {
                    typeAlgoriths.Add(t.Id, t.Section.Notation + "  -  " + t.Algoritm.Notation);
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

        /// <summary>
        /// Метод, по id записи в таблице расписания, возвращает полное название секции локомотива и название алгоритма.
        /// </summary>
        /// <param name="id">id записи в таблице расписания</param>
        /// <returns>Полное название секции локомотива и название алгоритма</returns>
        // GET: api/TimeTable/5
        public async Task<IHttpActionResult> Get(int id)
        {
            TimeTable timeTable = await db.TimeTables.FindAsync(id);
            if (timeTable == null)
            {
                return NotFound();
            }

            return Ok(timeTable.Section.Notation + "  " + timeTable.Algoritm.Name);

        }

        //// POST: api/TimeTable
        //public void Post(TimeTable timeTables)
        //{
        //}

        //// PUT: api/TimeTable/5
        //public void Put(int id, TimeTable timeTables)
        //{
        //}

        //// DELETE: api/TimeTable/5
        //public void Delete(int id)
        //{
        //}
    }
}
