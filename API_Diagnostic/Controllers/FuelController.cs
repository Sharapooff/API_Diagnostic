﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_Diagnostic.Controllers
{
    public class FuelController : ApiController
    {
        // GET: api/Fuel
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Fuel/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Fuel
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Fuel/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Fuel/5
        public void Delete(int id)
        {
        }
    }
}
