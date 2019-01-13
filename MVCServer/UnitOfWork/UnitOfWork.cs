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
        private MVCEntities _context = new MVCEntities();
        public BrunchRepository brunchRepository;
        public StaffRepository staffRepository;
        public PositionRepository positionRepository ;
        public OrdersRepository ordersRepository ;
        public GiftsRepository giftsRepository ;
        public ClientRepository clientRepository ;


        public BrunchRepository Brunches
        {
            get {
                if (brunchRepository == null)
                    brunchRepository = new BrunchRepository(_context);
                return brunchRepository;
            }
        }
        public StaffRepository Staff
        {
            get
            {
                if (staffRepository == null)
                    staffRepository = new StaffRepository(_context);
                return staffRepository;
            }
        }
        public ClientRepository Clients
        {
            get
            {
                if (clientRepository == null)
                   clientRepository = new ClientRepository(_context);
                return clientRepository;
            }
        }

        public GiftsRepository Gifts
        {
            get
            {
                if (giftsRepository == null)
                   giftsRepository = new GiftsRepository(_context);
                return giftsRepository;
            }
        }

        public OrdersRepository Orders
        {
            get
            {
                if (ordersRepository == null)
                   ordersRepository = new OrdersRepository(_context);
                return ordersRepository;
            }
        }
        public PositionRepository Positions
        {
            get
            {
                if (positionRepository == null)
                    positionRepository = new PositionRepository(_context);
                return positionRepository;
            }
        }   

        public virtual void Dispose()
        {
           
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