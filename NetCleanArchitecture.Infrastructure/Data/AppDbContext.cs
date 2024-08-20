
using Microsoft.EntityFrameworkCore;
using NetCleanArchitecture.Core.Entities;

namespace NetCleanArchitecture.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<EmployeeEntity> Employees { get; set; }
    }
}
