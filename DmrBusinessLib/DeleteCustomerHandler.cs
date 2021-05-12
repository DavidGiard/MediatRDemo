using DmrCommandsAndQueries.Commands;
using DmrDataAccessLib;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DmrBusinessLib
{
    public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerCommand>
    {
        private IDataAccess _dataAccess;
        public DeleteCustomerHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<Unit> Handle(DeleteCustomerCommand command, CancellationToken cancellationToken)
        {
            int id = command.Id;
            _dataAccess.DeleteCustomer(id);
            return Task.FromResult(Unit.Value);
        }
    }
}
