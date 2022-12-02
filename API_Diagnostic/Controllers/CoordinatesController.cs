using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_Diagnostic.Controllers
{
    public class CoordinatesController : ApiController
    {
        
        [Route("api/Coordinates/Location")]
        public IEnumerable<double> GetLocation(string notation)
        {

            return new double[] { 64.446, 51.653 };
        }

        // GET: api/Coordinates/5
        public string GetPath(string notation)
        {
            return "value";
        }
    }
}
