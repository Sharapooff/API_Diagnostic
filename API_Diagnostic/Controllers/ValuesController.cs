using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_Diagnostic.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        [Authorize]
        //[OverrideAuthorization]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
            //new JsonResult(Ваш объект)
        }

        // GET api/values/5
        [HttpGet]
        public string Get(int id)
        {
            return Convert.ToString(id);
        }
                
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete]
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
