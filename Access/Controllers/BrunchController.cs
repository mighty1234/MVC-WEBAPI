
using DTOLibrary;
using MVCServer;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Description;

namespace Access.Controllers
{
    public class BrunchController : ApiController
    {
        BrunchService service = new BrunchService();
        // GET: api/Brunch
        public IEnumerable<BrunchDto> Get()
        {
            try
            {
                return service.GetAll().Select(e => new BrunchDto(e));
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        // GET: api/Brunch/5
        [ResponseType(typeof(BrunchDto))]
        public IHttpActionResult Get(int id)
        {
            Brunch brunch = service.GetBuyId(id);
            try
            {

              
                if (brunch == null)
                {
                    return NotFound();
                }

                return Ok(new BrunchDto(brunch));
               
            }
            catch (Exception ex)
            {

                throw ex ;
            }
          
        }

        // POST: api/Brunch
        [ResponseType(typeof(BrunchDto))]
        public IHttpActionResult Post(Brunch brunch  )
        {
            try
            {
                service.Save(brunch);
                return CreatedAtRoute("DefaultApi", new { id = brunch.Id },new BrunchDto( brunch));
            }
            catch (Exception ex )
            {

                throw ex;
            }

         
        }

        // PUT: api/Brunch/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, Brunch brunch)
        {

            try
            {
                if (id != brunch.Id)
                    return BadRequest();
                service.Update(brunch);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (service.GetBuyId(id)==null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);

        }

        // DELETE: api/Brunch/5
        [ResponseType(typeof(BrunchDto))]
        public IHttpActionResult Delete(int id  )
        {
            try
            {
               Brunch brunch = service.GetBuyId(id);
                if (brunch == null)
                {
                    return NotFound();
                }

                service.Delete(id);
               

                return Ok( new BrunchDto(brunch));
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}
