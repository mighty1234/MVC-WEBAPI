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
        public void Delete(int id)
        {
            try
            {
                if (id ==0)
                    throw new ArgumentNullException(nameof(id));

                using (UnitOfWork unit = new UnitOfWork()) 
                {
                    var item =unit.Brunches.FindById(id);
                    unit.Brunches.Remove(item);
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
           IEnumerable<Brunch> x = new  List<Brunch>();

            try
            {
                using (UnitOfWork unit = new UnitOfWork())
                {
               
                    return unit.Brunches.GetAll();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        

        }

        public Brunch GetBuyId(int id)
        {
            Brunch x = new Brunch();
            try
            {
               
                    if (id == default(int))
                    throw new NullReferenceException(nameof(id));

                using (UnitOfWork unit = new UnitOfWork())
                {

                   return    unit.Brunches.FindById(id);                  

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

                using (UnitOfWork unit = new UnitOfWork())
                {

                    unit.Brunches.Add(entity);
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

                using (UnitOfWork unit = new UnitOfWork())
                {

                    unit.Brunches.Add(entity);
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