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
    public class StaffController : ApiController
    {
        StaffService service = new StaffService();
        // GET: api/Staff
        public IEnumerable<StaffDto> Get()
        {
            try
            {
                 return service.GetAll().Select(e => new StaffDto(e));
            }
            catch (Exception)
            {

                throw;
            }

          
        }

        // GET: api/Staff/5
        [ResponseType(typeof(StaffDto))]
        public IHttpActionResult Get(int id)
        {
            try
            {


                var staff = service.GetBuyId(id);
                if (staff == null)
                {
                    return NotFound();
                }
                return Ok(new StaffDto(staff));
            }
            catch (Exception ex )
            {

                throw ex;
            }
        }

        // POST: api/Staff
        [ResponseType(typeof(StaffDto))]
        public IHttpActionResult Post(Staff staff)
        {
            try
            {
                service.Save(staff);
                return CreatedAtRoute("DefaultApi", new { id = staff.Id },  new StaffDto(staff));
            }
          
            catch (Exception ex )
            {
                throw ex;
            }
        }

        // PUT: api/Staff/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, Staff staff)
        {

            if (id != staff.Id)            
                return BadRequest();
            
            try
            {
                service.Update(staff);

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
        // DELETE: api/Staff/5
        [ResponseType(typeof(Staff))]
        public IHttpActionResult DeleteWeapon(int id)
            {

            try
            {


            Staff staff = service.GetBuyId(id);
                if (staff == null)
                {
                    return NotFound();
                }

                service.Delete(id);           

                return Ok( new StaffDto(staff));
            }
            catch (Exception)
            {

                throw;
            }
            }

        
    }
}
