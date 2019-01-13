using MVCServer;
using MVCServer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.Services
{

    public class BrunchService : IService<Brunch>
    {
        private UnitOfWork unit = new UnitOfWork();
        public void Delete(Brunch entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));

                using (unit)
                {

                    unit.brunchRepository.Remove(entity);
                    unit.Save();

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public IEnumerable<Brunch> GetAll()
        {
            try
            {
                using (unit)
                {

                    return unit.brunchRepository.GetAll();

                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Brunch GetBuyId(int id)
        {
            try
            {
                if (id == default(int))
                    throw new NullReferenceException(nameof(id));

                using (unit)
                {

                    return unit.brunchRepository.FindById(id);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Save(Brunch entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));

                using (unit)
                {

                    unit.brunchRepository.Add(entity);
                    unit.Save();
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public void Update(Brunch entity)
        {
            try
            {

                using (unit)
                {

                    unit.brunchRepository.Add(entity);
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