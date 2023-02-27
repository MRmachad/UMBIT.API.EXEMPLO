using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using UMBIT.API.EXEMPLO.Servico;

namespace UMBIT.API.EXEMPLO.Configurations
{
    public static class InjectionDependencyConfiguration
    {
        public static void AddInjectionDependencyConfiguration(this IServiceCollection services)
        {
            

            services.AddScoped<IServicoDeGato, ServicoDeGato>();

            //services.Configure<ConexaoBD>(Configuration.GetSection("ConexaoBD"));
            //services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));  ---para as options  example

        }
    }
}
