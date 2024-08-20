using MediatR;
using NetCleanArchitecture.Core.Entities;
using NetCleanArchitecture.Core.Interfaces;

namespace NetCleanArchitecture.Application.Queries
{
    public record GetEmployeeByIdQuery(Guid employeeId) : IRequest<EmployeeEntity>;


    public class GetEmployeeByIdQueryHandler(IEmployeeRepository employeeRepository) : IRequestHandler<GetEmployeeByIdQuery, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await employeeRepository.GetEmployeeByIdAsync(request.employeeId);
        }
    }
}
