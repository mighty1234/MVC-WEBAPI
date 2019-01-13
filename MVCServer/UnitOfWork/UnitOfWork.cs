using MVCServer.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCServer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork

    {
        private static MVCEntities _context = new MVCEntities();
        public BrunchRepository brunchRepository= new BrunchRepository(_context);
        public StaffRepository staffRepository= new StaffRepository(_context);
        public PositionRepository positionRepository = new PositionRepository(_context);
        public OrdersRepository ordersRepository = new OrdersRepository(_context);
        public GiftsRepository giftsRepository = new GiftsRepository(_context);
        public ClientRepository clientRepository = new ClientRepository(_context);

        //private bool disposed = false;
       
        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}

       

        public virtual void Dispose()
        {
            //if (!this.disposed)
            //{
            //    if (disposing)
            //    {
            //        _context.Dispose();
            //    }
            //    this.disposed = true;
            //}
            if (_context != null)
            {
                _context.Dispose();
                _context = null;
            }
        }
        
           

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}