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
    public class PositionController : ApiController
    {
        PositionService service = new PositionService();
        // GET: api/Position
        public IEnumerable<PositionDto> Get()
        {
            try
            {

                return service.GetAll().Select(x => new PositionDto(x));
            }
            catch (Exception ex)
            {

                throw ex ;
            }
            
        }

        // GET: api/Position/5
        [ResponseType(typeof(PositionDto))]
        public IHttpActionResult Get(int id)
        {
            try
            {
                var position = service.GetBuyId(id);
                if (position == null)
                    return NotFound();

                return Ok(new PositionDto(position));
            }
            catch (Exception ex )
            {

                throw ex ;
            }
            
        }

        // POST: api/Position
        [ResponseType(typeof(PositionDto))]
        public IHttpActionResult Post(Position position)
        {
            try
            {
                service.Save(position);
                return CreatedAtRoute("DefaultApi", new { id = position.Id }, new PositionDto(position));
            }
            catch (Exception ex )
            {

                throw ex ;
            }
        }

        // PUT: api/Position/5
        [ResponseType(typeof(PositionDto))]
        public IHttpActionResult Put(int id,Position position)
        {
            try
            {
                if (id != position.Id)
                {
                    return BadRequest();
                }

                service.Update(position);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (service.GetBuyId(id) == null)
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

        // DELETE: api/Position/5
        public void Delete(int id)
        {

            try
            {
                service.Delete(id);
            }
            catch (Exception ex )
            {

                throw ex ;
            }
        }
    }
}
