using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCServer.Repositories
{
    public class ClientRepository : IRepository<Client>
    {
       
        private DbContext context;
        private DbSet<Client> _db;
        public ClientRepository(MVCEntities context)
        {
            this._db = context.Client;
            this.context = context;
        }
        public void Add(Client item)
        {
            _db.Add(item);
        }

        public Client FindById(int id)
        {
          return _db.Where(x=>x.Id==id).Include(x=>x.Orders).First();          
          
          
        }

        public IEnumerable<Client> GetAll()
        {
            return _db.Include(x=>x.Orders);
        }

        public void Remove(Client item)
        {
            _db.Remove(item);
        }

        public void Update(Client item)
        {
            _db.Attach(item);
            var entry = context.Entry(item);
            entry.State = EntityState.Modified;

        }
    }
}