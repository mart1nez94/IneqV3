﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IneqApi.Controllers
{
    public class StatusController : ApiController
    {
        // GET: api/Status
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Status/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Status
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Status/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Status/5
        public void Delete(int id)
        {
        }
    }
}
