using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SoloRPG.Domain.Sheets.Services;

namespace SoloRPG.Application.DependencyInjection;

public static class DependencyInjectionService
{
    extension(IServiceCollection services)
    {
        public IServiceCollection InjectDependencies(IConfiguration configuration) => services
            .InjectDatabase(configuration)
            .AddScoped<SheetCreationService>();
    }
}
