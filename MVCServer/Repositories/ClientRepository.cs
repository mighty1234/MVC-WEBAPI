using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCServer.Repositories
{
    public class ClientRepository : IRepository<Client>
    {
        private DbSet<Client> _db;
        public void Add(Client item)
        {
            _db.Add(item);
        }

        public Client FindById(int id)
        {
            return   _db.Find(id);
        }

        public IEnumerable<Client> GetAll()
        {
            return _db.ToList();
        }

        public void Remove(Client item)
        {
            _db.Remove(item);
        }
    }
}