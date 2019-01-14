﻿using MVCServer;
using MVCServer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.Services
{
    public class ClientService : IService<Client>
    {
       
        public void Delete(int id)
        {
            try
            {
                if(id == 0)
                    throw new ArgumentNullException(nameof(id));

                using (UnitOfWork unit = new UnitOfWork())
                {
                     var client= unit.Clients.FindById(id);
                    unit.Clients.Remove(client);
                    unit.Save();

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

           

        }

        public IEnumerable<Client> GetAll()
        {
            try
            {
                using (UnitOfWork unit = new UnitOfWork())
                {

                    return unit.Clients.GetAll();

                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            
        }

        public Client GetBuyId(int id)
        {
            try
            {
                if(id==default(int))
                    throw new NullReferenceException(nameof(id));

                using (UnitOfWork unit = new UnitOfWork())
                {

                    return unit.Clients.FindById(id);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }



        }

       

        public void Save(Client entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));

                using (UnitOfWork unit = new UnitOfWork())
                {

                    unit.Clients.Add(entity);
                    unit.Save();
                }
            }
            catch (Exception ex)
            {
                throw ex;             
              
            }

        }

        public void Update(Client entity)
        {
            try
            {

                using (UnitOfWork unit = new UnitOfWork())
                {

                    unit.Clients.Add(entity);
                    unit.Save();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}