using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Diagnostic.Models.ResultModels
{
    public class ResultDiagnostic
    {
        public bool RequestFailed { get; set; }
        public string RequestErrorMessage { get; set; }
        public bool PresenceDataFlag { get; set; }
        public string ObjectResult { get; set; }
        
        public ResultDiagnostic(bool presenceDataFlag = false, string objectResult = "", bool requestFailed = false, string requestErrorMessage = "")
        {
            this.RequestFailed = requestFailed;
            this.RequestErrorMessage = requestErrorMessage;
            this.PresenceDataFlag = presenceDataFlag;
            this.ObjectResult = objectResult;
        }
                
    }
}