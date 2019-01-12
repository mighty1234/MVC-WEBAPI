using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCServer.Repositories
{
    public class BrunchRepository : IRepository<Brunch>
    {
       private  DbSet<Brunch> _db;
        public void Add(Brunch item)
        {
            _db.Add(item);
        }

        public Brunch FindById(int id)
        {
            return _db.Find(id);
        }

        public IEnumerable<Brunch> GetAll()
        {
            return _db.ToList(); 
        }

        public void Remove(Brunch item)
        {
            _db.Remove(item);
        }
    }
}