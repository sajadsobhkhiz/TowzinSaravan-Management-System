using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowzinSaravan.DataLayer.Repositories;
using TowzinSaravan.DataLayer.Services;

namespace TowzinSaravan.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        TowzinSaravan_DBEntities db = new TowzinSaravan_DBEntities();

        private IUserRepository _userRepository;
        private ICustomerRepository _customerRepository;
        private IOrderRepository _orderRepository;
        private IProductTypeRepository _productTypeRepository;
        private IInvoiceRepository _invoiceRepository;
        private IDriverRepository _driverRepository;



        //private GenericRepository<Orders> _orderRepository;

        //public GenericRepository<Orders> OrderRepository
        //{
        //    get
        //    {
        //        if (_orderRepository == null)
        //        {
        //            _orderRepository = new GenericRepository<Orders>(db);
        //        }

        //        return _orderRepository;
        //    }
        //}

        public IUserRepository UserRepository 
        { 
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(db);
                }
                return _userRepository;
            }
        }

        public ICustomerRepository CustomerRepository 
        { get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(db);
                }
                return _customerRepository;
            }
        }

        public IOrderRepository OrderRepository
        {
            get
            {
                if (_orderRepository == null)
                {
                    _orderRepository = new OrderRepository(db);
                }
                return _orderRepository;
            }
        }

        public IProductTypeRepository productTypeRepository
        {
            get
            {
                if (_productTypeRepository == null)
                {
                    _productTypeRepository = new ProductTypeRepository(db);
                }
                return _productTypeRepository;
            }
        }

        public IInvoiceRepository invoiceRepository
        {
            get
            {
                if (_invoiceRepository == null)
                {
                    _invoiceRepository = new InvoiceRepository(db);
                }
                return _invoiceRepository;
            }
        }

        public IDriverRepository DriverRepository
        {
            get
            {
                if (_driverRepository == null)
                {
                    _driverRepository = new DriverRepository(db);
                }
                return _driverRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
