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
       
        public void Delete(int id )
        {
            try
            {
                if (id == 0)
                    throw new ArgumentNullException(nameof(id));

                using (UnitOfWork unit = new UnitOfWork())
                {
                    var position = unit.Positions.FindById(id);
                    unit.Positions.Remove(position);
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
            List<Position> positions = new List<Position>();
            try
                {
                    using (UnitOfWork unit = new UnitOfWork())
                    {

                       positions= unit.Positions.GetAll().ToList();
                    return positions;

                    }
                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }

        public Position GetBuyId(int id)
        {
            Position position = new Position();
            try
            {
                if (id == default(int))
                    throw new NullReferenceException(nameof(id));

                using (UnitOfWork unit = new UnitOfWork())
                {

                    position = unit.Positions.FindById(id);
                    return position;

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

                using (UnitOfWork unit = new UnitOfWork())
                {

                    unit.Positions.Add(entity);
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

                using (UnitOfWork unit = new UnitOfWork())
                {

                    unit.Positions.Add(entity);
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