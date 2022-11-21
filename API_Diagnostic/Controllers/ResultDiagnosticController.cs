using API_Diagnostic.Database;
using API_Diagnostic.Models;
using API_Diagnostic.Models.ResultModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_Diagnostic.Controllers
{
    //[Authorize]
    public class ResultDiagnosticController : ApiController
    {
        //// GET api/values
        //[Authorize]
        ////[OverrideAuthorization]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //    //new JsonResult(Ваш объект)
        //}

        //// GET api/values/5
        //[HttpGet]
        //public string Get(int id)
        //{
        //    return Convert.ToString(id);
        //}

        /// <summary>
        /// Метод возвращает результат диагностики секции локомотива, по определенному алгоритму.
        /// </summary>
        /// <param name="section">Секция локомотива, например "2ТЭ25КМ-443А". Обязательный параметр.</param>
        /// <param name="id">Id алгоритма диагностирования</param>
        /// <param name="compressed">Параметр, указывающий на то, возращать только флаг наличия отклонения по алгоритму или флаг, вместе с результатом.</param>
        /// <param name="AllAlgorims">Парамерт, указывающий, что необходимо вернуть признак наличия инциндента для всех алгоритмов диагностирования</param>
        /// <returns>Json object</returns>

        [HttpGet]
        public IHttpActionResult GetRezultDiagnostic(string sectionNotation, int algoritmId = 0, bool compressedData = false)
        {
            try
            {
                using (DiagServiceContext db = new DiagServiceContext())
                {
                    if (algoritmId != 0)
                    {
                        var incident = db.Incidents.Where(i => i.Section.Notation == sectionNotation).ToList().Where(i => i.AlgoritmId == algoritmId).OrderByDescending(i => i.DiagDT).FirstOrDefault();
                        if ((incident != null) && (incident?.PresenceFlag.Value == true))
                        {
                            return Json(new ResultDiagnostic(presenceDataFlag: true, objectResult: incident.DiagResult));//есть данные и объект результата
                        }
                    }
                    else
                    {
                        var incidents = db.Incidents.Where(i => i.DiagDT == db.Incidents.Where(i_ => i_.Section.Notation == sectionNotation)
                                                                                // .Where(i3 => i3.PresenceFlag == true)
                                                                                 .Max(i_ => i_.DiagDT)).Where(i_ => i_.PresenceFlag == true)
                                                                                 .ToList();
                        if (incidents != null)
                        {                                                      
                            if (compressedData == false)
                            {    
                                ResultObjectForAllAlgoritms resultAllAlgoritms = new ResultObjectForAllAlgoritms();                             
                                foreach (var i in incidents)
                                {
                                    resultAllAlgoritms.AddRecordToListResult(new RecordResult(i.AlgoritmId, i.PresenceFlag.Value, i.Algoritm.Notation, i.DiagResult));
                                }     
                                return Json(resultAllAlgoritms);//есть данные и объект результата                           
                            }
                            else 
                            {
                                List<int> idAlgorithmsList = new List<int>();
                                foreach (var i in incidents)
                                {
                                    idAlgorithmsList.Add(i.AlgoritmId);
                                }
                                return Json(idAlgorithmsList);//есть данные и объект результата 
                            }
                            
                        }
                    }
                }
                return Json(new ResultDiagnostic(presenceDataFlag:false));//нет данных
            }
            catch (Exception ex)
            {
                return Json(new ResultDiagnostic(requestFailed:true, requestErrorMessage:ex.Message));
            }
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //[HttpDelete]
        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
