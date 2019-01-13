using MVCServer;
using MVCServer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.Services
{ 
    public class StaffService : IService<Staff>
{
    private UnitOfWork unit = new UnitOfWork();
    public void Delete(Staff entity)
    {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));

                using (unit)
                {

                    unit.staffRepository.Remove(entity);
                    unit.Save();

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    public IEnumerable<Staff> GetAll()
    {
            try
            {
                using (unit)
                {

                    return unit.staffRepository.GetAll();

                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

    public Staff GetBuyId(int id)
    {
            try
            {
                if (id == default(int))
                    throw new NullReferenceException(nameof(id));

                using (unit)
                {

                    return unit.staffRepository.FindById(id);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    public void Save(Staff entity)
    {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));

                using (unit)
                {

                    unit.staffRepository.Add(entity);
                    unit.Save();
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

    public void Update(Staff entity)
    {
            try
            {

                using (unit)
                {

                    unit.staffRepository.Add(entity);
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