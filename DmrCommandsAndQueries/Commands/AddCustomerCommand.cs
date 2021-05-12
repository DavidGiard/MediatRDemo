using DmrModels;
using MediatR;
using System;

namespace DmrCommandsAndQueries.Commands
{
    public class AddCustomerCommand : IRequest<Customer>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Double Revenue { get; set; }
        public AddCustomerCommand(string firstName, string lastName, Double revenue)
        {
            FirstName = firstName;
            LastName = lastName;
            Revenue = revenue;
        }
    }
}
