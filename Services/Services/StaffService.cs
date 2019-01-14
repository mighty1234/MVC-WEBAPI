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
    public void Delete(int id)
    {
            try
            {
                if (id == 0)
                    throw new ArgumentNullException(nameof(id));

                using (UnitOfWork unit = new UnitOfWork())
                {
                    var staff = unit.Staff.FindById(id);
                    unit.Staff.Remove(staff);
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
                using (UnitOfWork unit = new UnitOfWork())
                {

                    return unit.Staff.GetAll();

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

                using (UnitOfWork unit = new UnitOfWork())
                {

                    return unit.Staff.FindById(id);

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

                using (UnitOfWork unit = new UnitOfWork())
                {

                    unit.Staff.Add(entity);
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

                using (UnitOfWork unit = new UnitOfWork())
                {

                    unit.Staff.Add(entity);
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