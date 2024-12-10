using Banking.Application.Peristence;
using Banking.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Banking.Application.UseCases.NewCustomer
{
    public class NewCustomerAddCommandHandler : IRequestHandler<NewCustomerAddCommand, int>
    {
        private ICustomerRepository repository;

        public NewCustomerAddCommandHandler(ICustomerRepository customerRepository)
        {
            repository = customerRepository;
        }

        public async Task<int> Handle(NewCustomerAddCommand request, CancellationToken cancellationToken)
        {
            var customer = new Customer {Address = request.Address, Name = request.Name,PAN = request.PAN};
            var result = await repository.AddCustomer(customer);
            return result.CustomerId;
        }
    }
}
