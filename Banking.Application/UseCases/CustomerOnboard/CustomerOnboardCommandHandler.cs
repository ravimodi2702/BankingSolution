using AutoMapper;
using Banking.Application.Peristence;
using FluentValidation;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Banking.Application.UseCases.CustomerOnboard
{
    public class CustomerOnboardCommandHandler : IRequestHandler<CutomerOnboardCommand, CustomerOnboardDto>
    {
        private readonly ICustomerRepository _customerRepostiory;
        private readonly IValidator<CutomerOnboardCommand> _validator;
        private readonly IMapper _mapper;
        //private readonly ILogging _logger;
        public CustomerOnboardCommandHandler(ICustomerRepository customerRepository, IValidator<CutomerOnboardCommand> validator, IMapper mapper)
        {
            _customerRepostiory = customerRepository;
            _validator = validator;
            _mapper = mapper;
          //  _logger = logging;
        }
        async Task<CustomerOnboardDto> IRequestHandler<CutomerOnboardCommand, CustomerOnboardDto>.Handle(CutomerOnboardCommand request, CancellationToken cancellationToken)
        {
            await _validator.ValidateAndThrowAsync(request);
            var customer = await _customerRepostiory.AddCustomer(request.Customer);
           // _logger.AddLog("customer created");
            return _mapper.Map<CustomerOnboardDto>(customer);
        }
    }
}
