
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NetCleanArchitecture.Core.Interfaces;
using NetCleanArchitecture.Core.Options;
using NetCleanArchitecture.Infrastructure.Data;
using NetCleanArchitecture.Infrastructure.Repositories;

namespace NetCleanArchitecture.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {

            services.AddDbContext<AppDbContext>((provider, options) =>

                options.UseSqlServer(provider.GetRequiredService<IOptionsSnapshot<ConnectionStringsOptions>>().Value.DefaultConnection));

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            return services;
        }
    }
}
