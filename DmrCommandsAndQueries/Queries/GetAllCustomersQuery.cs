using DmrModels;
using MediatR;
using System.Collections.Generic;

namespace DmrCommandsAndQueries.Queries
{
    public class GetAllCustomersQuery : IRequest<List<Customer>>
    {
    }
}
