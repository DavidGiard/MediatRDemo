using DmrCommandsAndQueries.Commands;
using DmrCommandsAndQueries.Queries;
using DmrModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DmrApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/Customer
        [HttpGet]
        public async Task<List<Customer>> Index()
        {
            return await _mediator.Send(new GetAllCustomersQuery());
        }

        // GET: api/Customer/1
        [HttpGet("{id}")]
        public async Task<Customer> Index(int id)
        {
            return await _mediator.Send(new GetCustomerQuery(id));
        }

        [HttpPost]
        public async Task<Customer> Post([FromBody] Customer customer)
        {
            var model = new AddCustomerCommand(customer.FirstName, customer.LastName, customer.Revenue);
            return await _mediator.Send(model);
        }

        [HttpPut]
        public async Task<Customer> Put([FromBody] Customer customer)
        {
            var model = new UpdateCustomerCommand(customer.Id, customer.FirstName, customer.LastName, customer.Revenue);
            return await _mediator.Send(model);
        }

        [HttpDelete("{id}")]
        public async Task<Unit> Delete(int id)
        {
            var model = new DeleteCustomerCommand(id);
            return await _mediator.Send(model);
        }
    }
}
