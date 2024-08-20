
using MediatR;
using NetCleanArchitecture.Core.Entities;
using NetCleanArchitecture.Core.Interfaces;

namespace NetCleanArchitecture.Application.Queries
{
    public record GetAllEmployeesQuery() : IRequest<IEnumerable<EmployeeEntity>>;

    public class GetAllEmployeesQueryHandler(IEmployeeRepository employeeRepository) : IRequestHandler<GetAllEmployeesQuery, IEnumerable<EmployeeEntity>>
    {
        public async Task<IEnumerable<EmployeeEntity>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            return await employeeRepository.GetEmployeesAsync();
        }
    }   


}
