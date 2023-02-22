using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace UMBIT.API.EXEMPLO.Configurates
{
    public static class ConfigureMigrates
    {
        public static void UseConfigureMigrates(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope())
            {
                var context = serviceScope?.ServiceProvider.GetRequiredService<DbContext>();
                if (context.Database.GetPendingMigrations().Any())
                {
                    try
                    {
                        context.Database.Migrate();
                    }
                    catch (Exception)
                    {
                        if (!context?.Database.EnsureCreated() ?? false)
                            context.Database.EnsureDeleted();
                            context.Database.Migrate();
                    }

                }
            }
        }
    }
}
