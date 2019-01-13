﻿using MVCServer;
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

            try {
                var values= unit.ordersRepository.GetAll();
                if (values==null)
                    throw new ArgumentNullException(nameof(Orders));
                return values;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        
      
        }

        public Orders GetBuyId(int id)
        {
            try
            {
                if (id == default(int))
                    throw new NullReferenceException(nameof(id));

                using (unit)
                {

                    return unit.ordersRepository.FindById(id);

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

                using (unit)
                {

                    unit.ordersRepository.Add(entity);
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

                using (unit)
                {

                    unit.ordersRepository.Add(entity);
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