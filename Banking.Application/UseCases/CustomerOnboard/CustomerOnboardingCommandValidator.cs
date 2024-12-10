using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Application.UseCases.CustomerOnboard
{
    public class CustomerOnboardingCommandValidator : AbstractValidator<CutomerOnboardCommand>
    {
        public CustomerOnboardingCommandValidator()
        {

            RuleFor(x => x.Customer.PAN).NotNull();
            RuleFor(x => x.Customer.PAN).NotEmpty();
            RuleFor(x => x.Customer.PAN).Length(10);
            RuleFor(x => x.Customer.Address).NotNull().NotEmpty();
        }
    }
}
