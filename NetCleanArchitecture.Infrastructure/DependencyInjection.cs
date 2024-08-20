
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NetCleanArchitecture.Core.Interfaces;
using NetCleanArchitecture.Infrastructure.Data;
using NetCleanArchitecture.Infrastructure.Repositories;

namespace NetCleanArchitecture.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CleanArchitectureDb;Trusted_Connection=True;MultipleActiveResultSets=true;"));

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            return services;
        }
    }
}
