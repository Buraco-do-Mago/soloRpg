using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SoloRPG.Application.Configurations;
using SoloRPG.Application.Enums;

namespace SoloRPG.Application.DependencyInjection;

public static class DatabaseInjectionService
{
    extension(IServiceCollection services)
    {
        public IServiceCollection InjectDatabase(IConfiguration configuration)
        {
            var databaseConfiguration = configuration.GetRequiredSection("Database").Get<DatabaseConfiguration>()!;
            services.AddDbContext<Data.Database>(options =>
            {
                switch (databaseConfiguration.Type)
                {
                    case DatabaseType.InMemory:
                        options.UseInMemoryDatabase("SoloRPG");
                        break;
                    case DatabaseType.Sqlite:
                        options.UseSqlite(databaseConfiguration.Connection);
                        break;
                    case DatabaseType.PostgreSql:
                        options.UseNpgsql(databaseConfiguration.Connection);
                        break;
                }
            });
            return services;
        }
    }
}
