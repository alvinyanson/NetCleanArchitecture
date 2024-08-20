using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCleanArchitecture.Application.Queries;

namespace NetCleanArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalVendorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ExternalVendorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployeesAsync()
        {
            var result = await _mediator.Send(new GetCoinDeskDataQuery());

            return Ok(result);
        }

        [HttpGet("joke")]
        public async Task<IActionResult> GetJokeAsync()
        {
            var result = await _mediator.Send(new GetJokeDataQuery());

            return Ok(result);
        }
    }
}
