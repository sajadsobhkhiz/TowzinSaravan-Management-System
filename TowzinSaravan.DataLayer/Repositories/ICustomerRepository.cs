using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowzinSaravan.ViewModel.Customers;



namespace TowzinSaravan.DataLayer.Repositories
{
    public interface ICustomerRepository
    {
        List<Customers> GetAllCustomers();
        List<ListCustomerViewModel> GetWheatCustomerName(string filter = "");
        List<ListCustomerViewModel> GetDustCustomerName(string filter = "");
        List<Customers> GetWheatCustomers();
        List<Customers> GetDustCustomers();
        IEnumerable<Customers> GetCustomersByFilter(string parameter);
        Customers GetCustomerById(int customerId);
        Customers GetCustomerByCustomerName(string name);
        Customers CheckCustomerForUpdate(int id, string name);
        string GetCustomerNameById(int Id);
        bool InsertCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool DeleteCustomer(Customers customer);
        bool DeleteCustomer(int customerId);
    }
}
