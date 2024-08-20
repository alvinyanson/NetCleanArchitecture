using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCleanArchitecture.Application.Commands;
using NetCleanArchitecture.Application.Queries;
using NetCleanArchitecture.Core.Entities;

namespace NetCleanArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<IActionResult> AddEmployeeAsync([FromBody] EmployeeEntity employeeEntity)
        {
            var result = await _mediator.Send(new AddEmployeeCommand(employeeEntity));

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployeesAsync()
        {
            var result = await _mediator.Send(new GetAllEmployeesQuery());

            return Ok(result);
        }

        [HttpGet("{employeeId}")]
        public async Task<IActionResult> GetEmployeeByIdAsync([FromRoute] Guid employeeId)
        {
            var result = await _mediator.Send(new GetEmployeeByIdQuery(employeeId));

            return Ok(result);
        }

        [HttpPut("{employeeId}")]
        public async Task<IActionResult> UpdateEmployeeAsync([FromRoute] Guid employeeId, [FromBody]  EmployeeEntity employeeEntity)
        {
            var result = await _mediator.Send(new UpdateEmployeeCommand(employeeId, employeeEntity));

            return Ok(result);
        }

        [HttpDelete("{employeeId}")]
        public async Task<IActionResult> DeleteEmployeeAsync([FromRoute] Guid employeeId)
        {
            var result = await _mediator.Send(new DeleteEmployeeCommand(employeeId));

            return Ok(result);
        }
    }
}
