using DmrCommandsAndQueries.Commands;
using DmrDataAccessLib;
using DmrModels;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DmrBusinessLib
{
    public class AddCustomerHandler : IRequestHandler<AddCustomerCommand, Customer>
    {
        private IDataAccess _dataAccess;
        public AddCustomerHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<Customer> Handle(AddCustomerCommand command, CancellationToken cancellationToken)
        {
            string firstName = command.FirstName;
            string lastName = command.LastName;
            double revenue = command.Revenue;
            Customer customer = new Customer() { FirstName = firstName, LastName = lastName, Revenue = revenue };
            return Task.FromResult(_dataAccess.AddCustomer(customer));
        }
    }
}
