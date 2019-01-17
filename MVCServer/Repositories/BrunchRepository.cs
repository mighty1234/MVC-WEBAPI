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
       private DbContext context;
        public BrunchRepository(MVCEntities context)
        {
           this._db = context.Brunch;
        this.context = context;

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

        public void Update(Brunch item)
        {
           _db.Attach(item);
            var entry =  this.context.Entry(item);
            entry.State = EntityState.Modified;


            //var entity = FindById(item.Id);
            //_db.Attach(entity);
            //var entry = context.Entry(item);
            //entry.State = EntityState.Modified;

            
        }
    
       
    }
}