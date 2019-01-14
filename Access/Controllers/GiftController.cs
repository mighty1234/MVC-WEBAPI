using DTOLibrary;
using MVCServer;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Access.Controllers
{
    public class GiftController : ApiController
    {
        GiftsService service = new GiftsService();
       // GET: api/Gift
        public IEnumerable<GiftsDto> Get()
        {

            try
            {
                return service.GetAll().Select(x => new GiftsDto(x));
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        // GET: api/Gift/5
        [ResponseType(typeof(GiftsDto))]
        public IHttpActionResult Get(int id)
        {
            try
            {
              Gifts gift = service.GetBuyId(id);
                if (gift == null)
                    return NotFound();
              return  Ok(new GiftsDto(gift));
            }
            catch (Exception ex )
            {

                throw ex;
            }
            
        }

        // POST: api/Gift
        [ResponseType(typeof(GiftsDto))]
        public IHttpActionResult Post(Gifts gift)
        {
            try
            {
                service.Save(gift);
                return CreatedAtRoute("DefaultApi", new { id = gift.Id }, gift);
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }

        // PUT: api/Gift/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id,Gifts gift)
        {
            try
            {
                if (id != gift.Id)
                {
                    return BadRequest();
                }

                service.Update(gift);
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

        // DELETE: api/Gift/5
        [ResponseType(typeof(GiftsDto))]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Gifts gift = service.GetBuyId(id);
                if (gift == null)
                    return NotFound();
                service.Delete(id);
                return Ok(new GiftsDto(gift));
            }
            catch (Exception ex )
            {

                throw ex ;
            }
        }
    }
}
