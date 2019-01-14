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
      
        public void Delete(int id )
        {

            try
            {
                if (id == 0)
                    throw new ArgumentNullException(nameof(id));

                using (UnitOfWork unit = new UnitOfWork())
                {
                    var gift = unit.Gifts.FindById(id);
                    unit.Gifts.Remove(gift);
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
                using (UnitOfWork unit = new UnitOfWork())
                {

                    return unit.Gifts.GetAll();

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

                using (UnitOfWork unit = new UnitOfWork())
                {

                    return unit.Gifts.FindById(id);

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

                using (UnitOfWork unit = new UnitOfWork())
                {

                    unit.Gifts.Add(entity);
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

                using (UnitOfWork unit = new UnitOfWork())
                {

                    unit.Gifts.Add(entity);
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