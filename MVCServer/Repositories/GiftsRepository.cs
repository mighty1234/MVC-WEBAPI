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
           return _db.Where(x => x.Id == id).Include(x => x.Orders).First();
        }

        public IEnumerable<Gifts> GetAll()
        {
            return _db.Include(X=>X.Orders);
        }

        public void Remove(Gifts item)
        {
            _db.Remove(item);
        }

        public void Update(Gifts item, DbContext context)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}