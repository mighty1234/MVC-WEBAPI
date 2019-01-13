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
        public BrunchRepository brunchRepository;
        public StaffRepository staffRepository;
        public PositionRepository positionRepository;
        public OrdersRepository ordersRepository;
        public GiftsRepository giftsRepository;
        public ClientRepository clientRepository;

        private bool disposed = false;
        private MVCEntities _context = new MVCEntities();
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

       

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }
        
           

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}