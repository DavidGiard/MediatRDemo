using DmrCommandsAndQueries.Queries;
using DmrDataAccessLib;
using DmrModels;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DmrBusinessLib
{
    public class GetAllCustomersHandler : IRequestHandler<GetAllCustomersQuery, List<Customer>>
    {
        private readonly IDataAccess _dataAccess;

        public GetAllCustomersHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<List<Customer>> Handle(GetAllCustomersQuery query, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.GetCustomers());
        }
    }
}
