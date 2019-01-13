using MVCServer;
using MVCServer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.Services
{
    public class OrderService : IService<Orders>
    {
        private UnitOfWork unit = new UnitOfWork();
        public void Delete(Orders entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));

                using (unit)
                {

                    unit.ordersRepository.Remove(entity);
                    unit.Save();

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Orders> GetAll()
        {
            return unit.ordersRepository.GetAll();
      
        }

        public Orders GetBuyId(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Orders entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Orders entity)
        {
            throw new NotImplementedException();
        }
    }
}