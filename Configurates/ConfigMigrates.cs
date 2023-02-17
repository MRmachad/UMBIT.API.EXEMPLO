using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Configuration;
using System.Data.Entity;
using UMBIT.Core.Repositorio.Contexto;

namespace UMBIT.API.EXEMPLO.Configurates
{
    public static class ConfigMigrates
    {
        public static void UseConfigureMigrates(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope())
            {
                var context = serviceScope?.ServiceProvider.GetRequiredService<DataContext>();
                var criarMigartions = !context?.Database.EnsureCreated() ?? false;
                if (criarMigartions)
                {
                    context?.Database.Migrate();
                }
            }
        }
    }
}
