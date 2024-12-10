using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application.Peristence
{
    public interface IAccountRepository
    {
        Task<bool> Widthraw(int customerId,  string accountId, decimal amount);
    }
}
