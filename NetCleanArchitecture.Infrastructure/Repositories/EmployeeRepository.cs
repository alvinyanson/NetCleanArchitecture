

using Microsoft.EntityFrameworkCore;
using NetCleanArchitecture.Core.Entities;
using NetCleanArchitecture.Core.Interfaces;
using NetCleanArchitecture.Infrastructure.Data;

namespace NetCleanArchitecture.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity employee)
        {
            employee.Id = Guid.NewGuid();

            _context.Employees.Add(employee);

            await _context.SaveChangesAsync();

            return employee;
        }

        public async Task<EmployeeEntity> UpdateEmployeeAsync(Guid employeeId, EmployeeEntity entity)
        {

            var employee = await GetEmployeeByIdAsync(employeeId);

            if (employee != null)
            {
                employee.Name = entity.Name;
                employee.Email = entity.Email;
                employee.Phone = entity.Phone;

                _context.Employees.Update(employee);

                await _context.SaveChangesAsync();
            }

            return entity;
        }

        public async Task<bool> DeleteEmployeeAsync(Guid id)
        {
            var employee = await GetEmployeeByIdAsync(id);

            if (employee != null)
            {
                _context.Employees.Remove(employee);

                return await _context.SaveChangesAsync() > 0;
            }

            return false;
        }


        public async Task<EmployeeEntity> GetEmployeeByIdAsync(Guid id)
        {
            return await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<EmployeeEntity>> GetEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }

    }
}
