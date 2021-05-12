using DmrModels;
using MediatR;

namespace DmrCommandsAndQueries.Queries
{
    public class GetCustomerQuery : IRequest<Customer>
    {
        public int Id { get; set; }
        public GetCustomerQuery(int id)
        {
            Id = id;
        }
    }
}
