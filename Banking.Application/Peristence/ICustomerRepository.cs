using Banking.Core;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application.Peristence
{
    public interface ICustomerRepository
    {
        Task<Customer> AddCustomer(Customer customer);
    }
}
