using System.Reflection;
using BumaSoft.DependencyWizard.Configurations;
using BumaSoft.DependencyWizard.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SoloRPG.Domain.Sheets.Services;

namespace SoloRPG.Application.DependencyInjection;

public static class DependencyInjectionService
{
    extension(IServiceCollection services)
    {
        public IServiceCollection InjectDependencies(IConfiguration configuration)
        {
            var assemblies = AppDomain
                .CurrentDomain
                .GetAssemblies()
                .Where(assembly => assembly.FullName!.StartsWith("SoloRPG"))
                .SelectMany(assembly => assembly.GetReferencedAssemblies()
                        .Concat([assembly.GetName()])
                        .Where(name => name.FullName!.StartsWith("SoloRPG"))
                        .Select(Assembly.Load))
                .Distinct()
                .ToArray();
            return services
                .InjectDatabase(configuration)
                .InjectServices(assemblies)
                .InjectConfigurations(configuration, assemblies);
        }
    }
}
