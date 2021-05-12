using DmrModels;
using System.Collections.Generic;
using System.Linq;

namespace DmrDataAccessLib
{
    public class DataAccess : IDataAccess
    {
        private List<Customer> _customers;
        public DataAccess()
        {
            _customers = new List<Customer>();
            _customers.Add(new Customer { Id = 1, FirstName = "Bill", LastName = "Gates", Revenue = 100000 });
            _customers.Add(new Customer { Id = 2, FirstName = "Steve", LastName = "Ballmer", Revenue = 200000 });
            _customers.Add(new Customer { Id = 3, FirstName = "Satya", LastName = "Nadella", Revenue = 300000 });
            _customers.Add(new Customer { Id = 4, FirstName = "David", LastName = "Giard", Revenue = 400000 });
        }

        public List<Customer> GetCustomers()
        {
            return _customers;
        }

        public Customer GetCustomer(int id)
        {
            var customer = _customers.FirstOrDefault(x => x.Id == id);
            return customer;
        }

        public Customer AddCustomer(Customer customer)
        {
            if (customer.Id == 0)
            {
                int nextId = _customers.Max(c => c.Id) + 1;
                customer.Id = nextId;
            }
            _customers.Add(customer);
            return customer;
        }

        public Customer AddCustomer(string firstName, string lastName)
        {
            int nextId = _customers.Max(c => c.Id) + 1;
            var customer = new Customer() { Id = nextId, FirstName = firstName, LastName = lastName };
            _customers.Add(customer);
            return customer;
        }

        public void DeleteCustomer(Customer customer)
        {
            _customers.Remove(customer);
        }

        public void DeleteCustomer(int id)
        {
            var customer = _customers.FirstOrDefault(x => x.Id == id);
            _customers.Remove(customer);
        }

        public Customer UpdateCustomer(Customer customer)
        {
            var matchingCustomer = _customers.FirstOrDefault(x => x.Id == customer.Id);
            if (matchingCustomer != null)
            {
                matchingCustomer.FirstName = customer.FirstName;
                matchingCustomer.LastName = customer.LastName;
                matchingCustomer.Revenue = customer.Revenue;
                return matchingCustomer;
            }
            else
            {
                return null;
            }
        }
    }
}
