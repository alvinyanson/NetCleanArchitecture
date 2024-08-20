
using MediatR;
using NetCleanArchitecture.Core.Entities;
using NetCleanArchitecture.Core.Interfaces;

namespace NetCleanArchitecture.Application.Commands
{
    public record AddEmployeeCommand(EmployeeEntity Employee) : IRequest<EmployeeEntity>;

    public class AddEmployeeCommandHandler : IRequestHandler<AddEmployeeCommand, EmployeeEntity>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public AddEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<EmployeeEntity> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await _employeeRepository.AddEmployeeAsync(request.Employee);
        }
    }

}
