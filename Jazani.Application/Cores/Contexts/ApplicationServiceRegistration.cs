using Jazani.Application.Admins.Services.Implementations;
using Jazani.Application.Admins.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Jazani.Application.Cores.Contexts
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddTransient<IOfficeService, OfficeService>();



            return services;
        }
    }
}
