using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Application.UseCases.Withdraw
{
    public class WithdrawCommand : IRequest<bool>
    {
        public int CustomerId { get; set; }
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }

        public WithdrawCommand(int customerId, string accountNumber, decimal amount)
        {
            CustomerId = customerId;
            AccountNumber = accountNumber;
            Amount = amount;
        }
    }
}
