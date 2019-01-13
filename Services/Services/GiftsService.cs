using MVCServer;
using MVCServer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.Services
{
    public class GiftsService : IService<Gifts>
    {
        private UnitOfWork unit = new UnitOfWork();
        public void Delete(Gifts entity)
        {

            try
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));

                using (unit)
                {

                    unit.giftsRepository.Remove(entity);
                    unit.Save();

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Gifts> GetAll()
        {
            try
            {
                using (unit)
                {

                    return unit.giftsRepository.GetAll();

                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Gifts GetBuyId(int id)
        {
            try
            {
                if (id == default(int))
                    throw new NullReferenceException(nameof(id));

                using (unit)
                {

                    return unit.giftsRepository.FindById(id);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Save(Gifts entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));

                using (unit)
                {

                    unit.giftsRepository.Add(entity);
                    unit.Save();
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public void Update(Gifts entity)
        {
            try
            {

                using (unit)
                {

                    unit.giftsRepository.Add(entity);
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