using DmrModels;
using System.Collections.Generic;

namespace DmrDataAccessLib
{
    public interface IDataAccess
    {
        List<Customer> GetCustomers();
        Customer GetCustomer(int id);
        Customer AddCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        void DeleteCustomer(int id);
        Customer UpdateCustomer(Customer customer);
    }
}
