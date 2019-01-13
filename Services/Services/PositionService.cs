using MVCServer;
using MVCServer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.Services
{
    public class PositionService : IService<Position>
    {
        private UnitOfWork unit = new UnitOfWork();
        public void Delete(Position entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));

                using (unit)
                {

                    unit.positionRepository.Remove(entity);
                    unit.Save();

                }

            }

            catch (Exception ex)
            {
                throw ex;

            }
        }


    public IEnumerable<Position> GetAll()
        {
                try
                {
                    using (unit)
                    {

                        return unit.positionRepository.GetAll();

                    }
                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }

        public Position GetBuyId(int id)
        {
            try
            {
                if (id == default(int))
                    throw new NullReferenceException(nameof(id));

                using (unit)
                {

                    return unit.positionRepository.FindById(id);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Save(Position entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));

                using (unit)
                {

                    unit.positionRepository.Add(entity);
                    unit.Save();
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public void Update(Position entity)
        {
            try
            {

                using (unit)
                {

                    unit.positionRepository.Add(entity);
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