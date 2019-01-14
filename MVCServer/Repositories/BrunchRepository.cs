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
        public BrunchRepository(MVCEntities context)
        {
           this._db = context.Brunch;
        }


        public void Add(Brunch item)
        {
            _db.Add(item);
        }

        public Brunch FindById(int id)
        {
          return  _db.Where(x => x.Id == id).Include(x => x.Orders).Include(x=>x.Staff).FirstOrDefault();
        }

        public IEnumerable<Brunch> GetAll()
        {
            return _db.Include(x=>x.Orders).Include(x=>x.Staff).ToList(); 
        }

        public void Remove(Brunch item)
        {
            _db.Remove(item);
        }

       
    }
}