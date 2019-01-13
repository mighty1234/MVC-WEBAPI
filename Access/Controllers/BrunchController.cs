using Model;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Access.Controllers
{
    public class BrunchController : ApiController
    {
        BrunchService service = new BrunchService();
        // GET: api/Brunch
        public IEnumerable<MVCServer.Brunch> Get()
        {
            return service.GetAll();
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
