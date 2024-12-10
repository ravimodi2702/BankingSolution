using Banking.Application.Peristence;
using Banking.Application.UseCases.CustomerOnboard;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Banking.Application.UseCases.Withdraw
{
    public class WidthdrawCommandHandler : IRequestHandler<WithdrawCommand, bool>
    {
        private readonly IAccountRepository _accountRepository;
        public WidthdrawCommandHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<bool> Handle(WithdrawCommand request, CancellationToken cancellationToken)
        {
            var isWithdrwan = await _accountRepository.Widthraw(request.CustomerId, request.AccountNumber, request.Amount);
            return isWithdrwan;
        }
    }
}
