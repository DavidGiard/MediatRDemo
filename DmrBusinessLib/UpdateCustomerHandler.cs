using DmrCommandsAndQueries.Commands;
using DmrDataAccessLib;
using DmrModels;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DmrBusinessLib
{
    public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerCommand, Customer>
    {
        private IDataAccess _dataAccess;
        public UpdateCustomerHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public Task<Customer> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            int id = request.Id;
            string firstName = request.FirstName;
            string lastName = request.LastName;
            double revenue = request.Revenue;
            Customer customer = new Customer() {Id = id, FirstName = firstName, LastName = lastName, Revenue = revenue };
            return Task.FromResult(_dataAccess.UpdateCustomer(customer));
        }
    }
}
