using NetCleanArchitecture.Application;
using NetCleanArchitecture.Infrastructure;

namespace NetCleanArchitecture.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiDI(this IServiceCollection services)
        {
            services.AddApplicationDI().AddInfrastructureDI();

            return services;
        }
    }
}
