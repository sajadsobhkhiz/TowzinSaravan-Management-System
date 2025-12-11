using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowzinSaravan.DataLayer.Repositories;
using TowzinSaravan.ViewModel.Customers;

namespace TowzinSaravan.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private TowzinSaravan_DBEntities db;

        public CustomerRepository(TowzinSaravan_DBEntities context)
        {
            db = context;
        }

        public List<Customers> GetAllCustomers()
        {
            return db.Customers.OrderBy(c => c.Name).ToList();
        }

        public Customers GetCustomerById(int customerId)
        {
            return db.Customers.Find(customerId);
        }

        public Customers GetCustomerByCustomerName(string name)
        {
            return db.Customers.Where(c => c.Name == name).SingleOrDefault();
        }

        public Customers CheckCustomerForUpdate(int id, string name)
        {
            return db.Customers.Where(c => c.Name == name && c.Id != id).SingleOrDefault();
        }

        public bool InsertCustomer(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var customer = GetCustomerById(customerId);
                DeleteCustomer(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Customers> GetCustomersByFilter(string parameter)
        {
            throw new NotImplementedException();
        }

        public string GetCustomerNameById(int customerId)
        {
            return db.Customers.Find(customerId).Name;
        }

        public List<ListCustomerViewModel> GetWheatCustomerName(string filter = "")
        {
            if (filter == "")
            {
                return db.Customers.Where(c => c.IsDust==false).Select(c => new ListCustomerViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                }).OrderBy(c => c.Name).ToList();
            }

            return db.Customers.Where(c => c.Name.Contains(filter) && c.IsDust == false).Select(c => new ListCustomerViewModel()
            {
                Id = c.Id,
                Name = c.Name
            }).OrderBy(c => c.Name).ToList();
        }

        public List<ListCustomerViewModel> GetDustCustomerName(string filter = "")
        {
            if (filter == "")
            {
                return db.Customers.Where(c => c.IsDust == true).Select(c => new ListCustomerViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                }).OrderBy(c => c.Name).ToList();
            }

            return db.Customers.Where(c => c.Name.Contains(filter) && c.IsDust == false).Select(c => new ListCustomerViewModel()
            {
                Id = c.Id,
                Name = c.Name
            }).OrderBy(c => c.Name).ToList();
        }

        public List<Customers> GetWheatCustomers()
        {
            return db.Customers.Where(c => c.IsDust == false).OrderBy(c => c.Name).ToList();
        }

        public List<Customers> GetDustCustomers()
        {
            return db.Customers.Where(c => c.IsDust == true).OrderBy(c => c.Name).ToList();
        }

    }
}
