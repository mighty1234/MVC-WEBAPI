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
            return _db.Find(id);
        }

        public IEnumerable<Staff> GetAll()
        {
            return _db.ToList();
        }

        public void Remove(Staff item)
        {
            _db.Remove(item);
        }
    }
}