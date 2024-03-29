﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCServer.Repositories
{
    public class OrdersRepository : IRepository<Orders>
    {
       
        private DbContext context;
        private DbSet<Orders> _db;
        public OrdersRepository(MVCEntities context)
        {
            this._db = context.Orders;
            this.context = context;
        }
        public void Add(Orders item)
        {
            _db.Add(item);
        }

        public Orders FindById(int id)
        {
            return _db.Where(x => x.Id == id).Include(x => x.Client).Include(x => x.Brunch)
                .Include(y => y.Gifts).Include(x => x.Staff).First();
        }

        public IEnumerable<Orders> GetAll()
        {
            return _db.Include(x => x.Client).Include(x => x.Brunch)
                .Include(y => y.Gifts).Include(x => x.Staff);
        }

        public void Remove(Orders item)
        {
                _db.Remove(item);
        }

        public void Update(Orders item)
        {
            _db.Attach(item);
            var entry = context.Entry(item);
            entry.State = EntityState.Modified;
        }
    }
}