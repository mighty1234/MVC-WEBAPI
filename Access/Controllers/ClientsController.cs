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
    public class ClientsController : ApiController
    {
        ClientService service = new ClientService();
        // GET: api/Clients
        public IEnumerable<ClientDto> Get()
        {

            try
            {
                return service.GetAll().Select(x => new ClientDto(x));

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // GET: api/Clients/5
        [ResponseType(typeof(ClientDto))]
        public IHttpActionResult Get(int id)
        {
            try
            {
                if (id != 0)
                {
                    Client client = service.GetBuyId(id);
                    if (client == null)
                        return NotFound();

                    return Ok(new ClientDto(client));
                }
                else
                    return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        // POST: api/Clients
        [ResponseType(typeof(ClientDto))]
        public IHttpActionResult Post(Client client)
        {
            try
            {
                service.Save(client);
                return CreatedAtRoute("DefaultApi", new { id = client.Id }, new ClientDto(client));

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT: api/Clients/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, Client client)
        {
            try
            {
                if (id != client.Id)
                {
                    return BadRequest();
                }
                service.Update(client);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (service.GetBuyId(id) == null)
                {
                    return NotFound();
                }
                else
                {
                    throw ex;
                }
            }
            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE: api/Clients/5
        [ResponseType(typeof(ClientDto))]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Client client = service.GetBuyId(id);
                if (client == null)
                    return NotFound();

                service.Delete(id);
                return Ok(new ClientDto(client));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
