using MVCServer;
using MVCServer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.Services
{
    public class ClientService : IService<Client>
    {
        private UnitOfWork unit = new UnitOfWork();
        public void Delete(Client entity)
        {
            try
            {
                if(entity == null)
                    throw new ArgumentNullException(nameof(entity));

                using (unit)
                {

                    unit.clientRepository.Remove(entity);
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
                using (unit)
                {

                    return unit.clientRepository.GetAll();

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

                using (unit)
                {

                    return unit.clientRepository.FindById(id);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }



        }

        //public IEnumerable<Client> GetByprop()
        //{
        //    throw new NotImplementedException();
        //}

        public void Save(Client entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));

                using (unit)
                {

                    unit.clientRepository.Add(entity);
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

                using (unit)
                {

                    unit.clientRepository.Add(entity);
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