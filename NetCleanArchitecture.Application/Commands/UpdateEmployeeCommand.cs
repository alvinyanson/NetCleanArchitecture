
using MediatR;
using NetCleanArchitecture.Core.Entities;
using NetCleanArchitecture.Core.Interfaces;

namespace NetCleanArchitecture.Application.Commands
{
    public record UpdateEmployeeCommand(Guid Id, EmployeeEntity Employee) : IRequest<EmployeeEntity>;

    public class UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository) : IRequestHandler<UpdateEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.UpdateEmployeeAsync(request.Id, request.Employee);
        }
    }

}
