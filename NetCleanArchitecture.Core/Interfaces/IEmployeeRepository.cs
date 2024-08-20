
using NetCleanArchitecture.Core.Entities;

namespace NetCleanArchitecture.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeEntity>> GetEmployeesAsync();

        Task<EmployeeEntity> GetEmployeeByIdAsync(Guid id);

        Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity employee);

        Task<EmployeeEntity> UpdateEmployeeAsync(Guid id, EmployeeEntity employee);

        Task<bool> DeleteEmployeeAsync(Guid id);
    }
}
