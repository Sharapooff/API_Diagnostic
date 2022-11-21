using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Diagnostic.Models.ResultModels
{
    public class ResultObjectForAllAlgoritms
    {
        public List<IRecordResult> listResults;

        public ResultObjectForAllAlgoritms()
        {
             this.listResults = new List<IRecordResult>();
        }

        public ResultObjectForAllAlgoritms(List<IRecordResult>  listResult):base()
        {
            this.listResults = listResult;
        }

        public bool AddRecordToListResult(IRecordResult record)
        {
            try
            {
                this.listResults.Add(record);
                return true;
            }
            catch
            {
                return false;
            }            
        }
    }

    public interface IRecordResult
    {
        int AlgorithmId { get; set; }
        bool PresenceDataFlag { get; set; }
        string AlgorithmNotation { get; set; }
        string ObjectResultAlgorithm { get; set; }
    }

    public class RecordResult : IRecordResult
    {
        int algorithmId;
        bool presenceDataFlag;
        string algorithmNotation;
        string objectResultAlgorithm;

        public int AlgorithmId { get => algorithmId; set { if (value >= 0) algorithmId = value; } }
        public bool PresenceDataFlag { get => presenceDataFlag; set { presenceDataFlag = value; } }
        public string AlgorithmNotation { get => algorithmNotation; set { algorithmNotation = value; } }
        public string ObjectResultAlgorithm { get => objectResultAlgorithm; set { objectResultAlgorithm = value; } }

        public RecordResult(int algorithmId, bool presenceDataFlag, string algorithmNotation, string objectResultAlgorithm)
        {
            this.AlgorithmId = algorithmId;
            this.PresenceDataFlag = presenceDataFlag;
            this.AlgorithmNotation = algorithmNotation;
            this.ObjectResultAlgorithm = objectResultAlgorithm;
        }
    }


}