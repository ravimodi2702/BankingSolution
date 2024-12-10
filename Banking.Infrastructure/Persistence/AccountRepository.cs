using Banking.Application.Peristence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Infrastructure.Persistence
{
    public class AccountRepository : IAccountRepository
    {
        public Task<bool> Widthraw(int customerId, string accountId, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
