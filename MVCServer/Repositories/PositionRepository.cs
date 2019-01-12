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
            return _db.Find(id);
        }

        public IEnumerable<Position> GetAll()
        {
            return _db.ToList();
        }

        public void Remove(Position item)
        {
            _db.Remove(item);
        }
    }
}