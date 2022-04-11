using Microsoft.Extensions.DependencyInjection;
using TEST_CRECER_BUSINESS.Business;
using TEST_CRECER_BUSINESS.Interfaces;
using TEST_CRECER_DATA;
using TEST_CRECER_DATA.BD;
using TEST_CRECER_DATA.Interfaces;

namespace TEST_CRECER_BUSINESS.Providers
{
    public static class ServiceProviders
    {
        public static IServiceCollection addServices(this IServiceCollection services)
        {
            services.AddTransient<IPacienteData, PacienteData>();
            services.AddTransient<IPacientesBusiness, PacienteBusiness>();

            services.AddTransient<ICitaData, CitaData>();
            services.AddTransient<ICitaBusiness, CitaBusiness>();
            return services;
        }
    }
}
