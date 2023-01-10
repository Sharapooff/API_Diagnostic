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
        ///// <summary>
        ///// Метод возвращает результат диагностики секции локомотива, по определенному алгоритму.
        ///// </summary>
        ///// <param name="sectionNotation">Секция локомотива, например "2ТЭ25КМ-443А". Обязательный параметр.</param>
        ///// <param name="algoritmId">Id алгоритма диагностирования. Если = 0, то возвращает по всем.</param>
        ///// <param name="compressedData">Параметр, указывающий на то, возращать только флаг наличия отклонения по алгоритму или флаг, вместе с результатом.</param>
        ///// <returns>Сложный Object в формате Json </returns>
        ///// <simple>Сложный Object в формате Json </simple>
        //[HttpGet]
        //[Route("api/RezultDiagnostic")]
        //public IHttpActionResult GetRezultDiagnostic(string sectionNotation, int algoritmId = 0, bool compressedData = false)
        //{
        //    try
        //    {
        //        using (DiagServiceContext db = new DiagServiceContext())
        //        {
        //            var a = db.Algoritms.ToList();
        //            if (algoritmId != 0)
        //            {
        //                var incident = db.Incidents.Where(i => i.Section.Notation == sectionNotation).ToList().Where(i => i.AlgoritmId == algoritmId).OrderByDescending(i => i.DiagDT).FirstOrDefault();
        //                if ((incident != null) && (incident?.PresenceFlag.Value == true))
        //                {

        //                    return Json(new ResultDiagnostic(presenceDataFlag: true, objectResult: incident.DiagResult));//есть данные и объект результата
        //                }
        //            }
        //            else
        //            {
        //                var incidents = db.Incidents.Where(i => i.DiagDT == db.Incidents.Where(i_ => i_.Section.Notation == sectionNotation)
        //                                                                         .Max(i_ => i_.DiagDT)).Where(i_ => i_.PresenceFlag == true)
        //                                                                         .ToList();
        //                if (incidents != null)
        //                {                                                      
        //                    if (compressedData == false)
        //                    {    
        //                        ResultObjectForAllAlgoritms resultAllAlgoritms = new ResultObjectForAllAlgoritms();                             
        //                        foreach (var i in incidents)
        //                        {
        //                            resultAllAlgoritms.AddRecordToListResult(new RecordResult(i.AlgoritmId, i.PresenceFlag.Value, i.Algoritm.Notation, i.DiagResult));
        //                        }     
        //                        return Json(resultAllAlgoritms);//есть данные и объект результата                           
        //                    }
        //                    else 
        //                    {
        //                        List<int> idAlgorithmsList = new List<int>();
        //                        foreach (var i in incidents)
        //                        {
        //                            idAlgorithmsList.Add(i.AlgoritmId);
        //                        }
        //                        return Json(idAlgorithmsList);//есть данные и объект результата 
        //                    }
                            
        //                }
        //            }
        //        }
        //        return Json(new ResultDiagnostic(presenceDataFlag:false));//нет данных
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new ResultDiagnostic(requestFailed:true, requestErrorMessage:ex.Message));
        //    }
        //}

        /// <summary>
        /// Получение результата диагностирования секции по алгоритму диагностирования.
        /// </summary>
        /// <param name="sectionId">Id секции</param>
        /// <param name="algoritmId">Id алгоритма диагностирования</param>
        /// <returns>Результаты диагностирования в виде объекта в формате json</returns>
        [HttpGet]
        [Route("api/DiagnosticRezult")]
        public IHttpActionResult GetDiagnosticRezult(int sectionId, int algoritmId)
        {
            try
            {
                using (DiagServiceContext db = new DiagServiceContext())
                {
                    var a = db.Algoritms.ToList();
                    if (algoritmId != 0)
                    {
                        //var incident = db.Incidents.Where(i => i.Section.Notation == sectionNotation).ToList().Where(i => i.AlgoritmId == algoritmId).OrderByDescending(i => i.DiagDT).FirstOrDefault();
                        var incident = db.Incidents.Where(i => i.Section.Id == sectionId).ToList().Where(i => i.AlgoritmId == algoritmId).OrderByDescending(i => i.DiagDT).FirstOrDefault();
                        if (incident != null)
                        {
                            if (incident?.PresenceFlag.Value == true)
                            {
                                return Ok(incident.DiagResult);//есть данные и объект результата
                            }         
                        }
                        return BadRequest("Инцедентов не выявлено!");
                    }
                    else
                    {
                        return BadRequest("Id алгоритма задан не верно!");
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Получение флага результата диагностирования секции по алгоритму диагностирования.
        /// </summary>
        /// <param name="sectionId">Id секции</param>
        /// <param name="algoritmId">Id алгоритма диагностирования</param>
        /// <returns>Результаты диагностирования в виде флага наличия отклонения, по Id алгоритма.</returns>
        [HttpGet]
        [Route("api/FlagDiagnosticRezult")]
        public IHttpActionResult GetFlagDiagnosticRezult(int sectionId, int algoritmId)
        {
            try
            {
                using (DiagServiceContext db = new DiagServiceContext())
                {
                    var a = db.Algoritms.ToList();
                    if (algoritmId != 0)
                    {
                        //var incident = db.Incidents.Where(i => i.Section.Notation == sectionNotation).ToList().Where(i => i.AlgoritmId == algoritmId).OrderByDescending(i => i.DiagDT).FirstOrDefault();
                        var incident = db.Incidents.Where(i => i.Section.Id == sectionId).ToList().Where(i => i.AlgoritmId == algoritmId).OrderByDescending(i => i.DiagDT).FirstOrDefault();
                        if (incident != null)
                        {
                            if (incident?.PresenceFlag.Value == true)
                            {
                                return Ok(incident.PresenceFlag);//есть данные и объект результата
                            }
                        }
                        return BadRequest("Инцедентов не выявлено!");
                    }
                    else
                    {
                        return BadRequest("Id алгоритма задан не верно!");
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
