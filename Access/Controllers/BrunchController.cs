
using MVCServer;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;

namespace Access.Controllers
{
    public class BrunchController : ApiController
    {
        BrunchService service = new BrunchService();
        // GET: api/Brunch
        public IEnumerable<Brunch> Get()
        {
            var x = (List<Brunch>)service.GetAll();

            return x;
        }

        // GET: api/Brunch/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Brunch
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Brunch/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Brunch/5
        public void Delete(int id)
        {
        }
    }
}
