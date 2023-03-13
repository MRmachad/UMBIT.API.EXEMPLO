using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UMBIT.API.EXEMPLO.Servico;
using UMBIT.Prototico.Core.API.Configurate.RequestConfigurate;

namespace UMBIT.API.EXEMPLO.Configurations
{
    public static class InjectionDependencyConfiguration
    {
        public static void AddInjectionDependencyConfiguration(this IServiceCollection services, ConfigurationManager configuration)
        {

            services.AddUMBITRequestConfigurate<IServicoDeAPI, ServicoDeAPI>(configuration, "testeAPI");
            services.AddScoped<IServicoDeGato, ServicoDeGato>();

            //services.Configure<ConexaoBD>(Configuration.GetSection("ConexaoBD"));
            //services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));  ---para as options  example

        }
    }
}
