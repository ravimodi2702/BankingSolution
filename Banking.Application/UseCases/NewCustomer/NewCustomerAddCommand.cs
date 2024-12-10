using Banking.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Application.UseCases.NewCustomer
{
    public class NewCustomerAddCommand : IRequest<int>
    {
        public string Address { get; set; }
        public string Name { get; set; }
        public string PAN { get; set; }
    }
}
