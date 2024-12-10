using Banking.Application.UseCases.CustomerOnboard;
using Banking.Application.UseCases.Withdraw;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
   // [Authorize]
    public class CustomerController : ControllerBase
    {

        private readonly ILogger<CustomerController> _logger;
        private readonly IMediator _mediator;

        public CustomerController(ILogger<CustomerController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost]
        [Route("onboard")]
       // [Authorize(Policy = "IsManager")]
        [ProducesResponseType(typeof(CustomerOnboardDto), 200)]
        public async Task<ActionResult<string>> Post(/*Bind() */ CutomerOnboardCommand command)
        {
            var customer = await _mediator.Send(command);
            return Ok(customer);
        }

        /* [HttpPost]
         [Route("newAccount")]
         [Authorize(Policy = "IsManager")]
         public async Task<ActionResult<string>> Post(NewAccount command)
         {
             var customerId = await _mediator.Send(command);
             return Ok(customerId);
         }*/

        /* [HttpPost]
        [Route("deposit")]
        public async Task<ActionResult<string>> Post(DepositCommand command)
        {
            var customerId = await _mediator.Send(command);
            return Ok(customerId);
        }*/

        [HttpPost]
        [Route("withdraw")]
        public async Task<ActionResult<bool>> Post(WithdrawCommand command)
        {
            var isSuccesful =  await _mediator.Send(command);
            return Ok(isSuccesful);
        }
    }
}
