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
        public void Delete(int id)
        {
            try
            {
                if (id == 0)
                    throw new ArgumentNullException(nameof(id));

                using (UnitOfWork unit = new UnitOfWork())
                {
                    var order = unit.Orders.FindById(id);
                    unit.Orders.Remove(order);
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

            IEnumerable<Orders> x = new List<Orders>();

            try {
                using (UnitOfWork unit = new UnitOfWork())
                {
                    x = unit.Orders.GetAll();
                    if (x == null)
                        throw new ArgumentNullException(nameof(Orders));
                   return x;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        
      
        }

        public Orders GetBuyId(int id)
        {
            Orders order = new Orders();
            try
            {
                if (id == default(int))
                    throw new NullReferenceException(nameof(id));

                using (UnitOfWork unit = new UnitOfWork())
                {

                    order= unit.Orders.FindById(id);
                    return order;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Save(Orders entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));

                using (UnitOfWork unit = new UnitOfWork())
                {

                    unit.Orders.Add(entity);
                    unit.Save();
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public void Update(Orders entity)
        {
            try
            {

                using (UnitOfWork unit = new UnitOfWork())
                {

                    unit.Orders.Add(entity);
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