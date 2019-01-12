using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCServer.Repositories
{
    public class OrdersRepository : IRepository<Orders>
    {
        private DbSet<Orders> _db;
        public void Add(Orders item)
        {
            _db.Add(item);
        }

        public Orders FindById(int id)
        {
          return  _db.Find(id);
        }

        public IEnumerable<Orders> GetAll()
        {
            return _db.ToList();
        }

        public void Remove(Orders item)
        {
                _db.Remove(item);
        }
    }
}