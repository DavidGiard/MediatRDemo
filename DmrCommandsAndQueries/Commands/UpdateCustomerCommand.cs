using DmrModels;
using MediatR;
using System;

namespace DmrCommandsAndQueries.Commands
{
    public class UpdateCustomerCommand : IRequest<Customer>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Double Revenue { get; set; }
        public UpdateCustomerCommand(int id, string firstName, string lastName, Double revenue)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Revenue = revenue;
        }
    }
}
