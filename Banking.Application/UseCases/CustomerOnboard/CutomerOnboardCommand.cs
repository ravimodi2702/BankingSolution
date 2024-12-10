using Banking.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Application.UseCases.CustomerOnboard
{
    public class CutomerOnboardCommand : IRequest<CustomerOnboardDto>
    {
        public Customer Customer { get; set; }
    }
}
