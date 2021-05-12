using DmrCommandsAndQueries.Queries;
using DmrDataAccessLib;
using DmrModels;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DmrBusinessLib
{
    public class GetCustomerHandler : IRequestHandler<GetCustomerQuery, Customer>
    {
        private readonly IDataAccess _dataAccess;
        public GetCustomerHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<Customer> Handle(GetCustomerQuery query, CancellationToken cancellationToken)
        {
            var customerId = query.Id;
            Customer customer = _dataAccess.GetCustomer(customerId);
            return Task.FromResult(customer);
        }
    }
}
