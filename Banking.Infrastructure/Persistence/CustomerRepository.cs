using Banking.Application.Peristence;
using Banking.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Infrastructure.Persistence
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task<Customer> AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
