using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SoloRPG.Application.DependencyInjection;

public static class DependencyInjectionService
{
    extension(IServiceCollection services)
    {
        public IServiceCollection InjectDependencies(IConfiguration configuration) => services.InjectDatabase(configuration);
    }
}
