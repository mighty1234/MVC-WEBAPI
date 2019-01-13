using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCServer.Repositories
{
    public class StaffRepository : IRepository<Staff>
    {
        private DbSet<Staff> _db;
        public void Add(Staff item)
        {
            _db.Add(item);
        }

        public Staff FindById(int id)
        {
            return _db.Include(y => y.Brunch).Include(y => y.Position).Include(y => y.Orders).Where(x => x.Id == id).First();
        }

        public IEnumerable<Staff> GetAll()
        {
            return _db.Include(y => y.Brunch).Include(y => y.Position).Include(y => y.Orders);
        }

        public void Remove(Staff item)
        {
            _db.Remove(item);
        }

        public void Update(Staff item, DbContext context)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}