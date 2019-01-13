using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCServer.Repositories
{
    public class PositionRepository : IRepository<Position>
    {
        private DbSet<Position> _db;
        public void Add(Position item)
        {
            _db.Add(item);
        }

        public Position FindById(int id)
        {
            return _db.Include(x => x.Staff).Where(x => x.Id == id).First();
        }

        public IEnumerable<Position> GetAll()
        {
            return _db.Include(y=>y.Staff);
        }

        public void Remove(Position item)
        {
            _db.Remove(item);
        }
       
    }
}