using Microsoft.Extensions.DependencyInjection;
using TEST_CRECER_BUSINESS.Interfaces;
using TEST_CRECER_DATA;

namespace TEST_CRECER_BUSINESS.Providers
{
    public static class ServiceProviders
    {
        public static IServiceCollection addServices(this IServiceCollection services)
        {
            services.AddTransient<IPacienteData, PacienteData>();
            services.AddTransient<IPacientesBusiness, PacienteBusiness>();
            return services;
        }
    }
}
