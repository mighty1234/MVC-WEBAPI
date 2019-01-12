using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCServer.Repositories
{
    public class GiftsRepository : IRepository<Gifts>
    {
        private DbSet<Gifts> _db;
        public void Add(Gifts item)
        {
            _db.Add(item);
        }

        public Gifts FindById(int id)
        {
            return _db.Find(id);
        }

        public IEnumerable<Gifts> GetAll()
        {
            return _db.ToList();
        }

        public void Remove(Gifts item)
        {
            _db.Remove(item);
        }
    }
}