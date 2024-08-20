using NetCleanArchitecture.Application;
using NetCleanArchitecture.Infrastructure;
using NetCleanArchitecture.Core;

namespace NetCleanArchitecture.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationDI().AddInfrastructureDI().AddCoreDI(configuration);

            return services;
        }
    }
}
