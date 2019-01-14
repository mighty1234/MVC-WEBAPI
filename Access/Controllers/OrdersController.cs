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
    public class OrdersController : ApiController
    {
        OrderService service = new OrderService();
        // GET: api/Orders
        public IEnumerable<OrdersDto> Get()
        {
            try
            {
                return service.GetAll().Select(x => new OrdersDto(x));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: api/Orders/5
        [ResponseType(typeof(OrdersDto))]
        public IHttpActionResult Get(int id)
        {
            try
            {
                Orders order = service.GetBuyId(id);
                if (order == null)
                    return NotFound();

                return Ok(new OrdersDto(order));
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        // POST: api/Orders
        [ResponseType(typeof(OrdersDto))]
        public IHttpActionResult Post(Orders order)
        {
            try
            {
                service.Save(order);
                return CreatedAtRoute("DefaultApi", new { id = order.Id }, new OrdersDto(order));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT: api/Orders/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, Orders order)
        {
            try
            {
                if (id != order.Id)
                    return BadRequest();

                service.Update(order);
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
    

        // DELETE: api/Orders/5
        [ResponseType(typeof(OrdersDto))]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Orders order = service.GetBuyId(id);
                if (order == null)
                    return NotFound();
                service.Delete(id);
                return Ok(new OrdersDto(order));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
