using AutoMapper;
using Banking.Core;

namespace Banking.Application.UseCases.CustomerOnboard
{
    public class CustomerOnboardMapper : Profile
    {
        public CustomerOnboardMapper()
        {
            CreateMap<Customer, CustomerOnboardDto>().ReverseMap();
        }
    }
}
