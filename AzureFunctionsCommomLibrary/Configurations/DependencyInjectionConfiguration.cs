using AzureFunctionsCommomLibrary.Data.Interfaces.TableStorage;
using AzureFunctionsCommomLibrary.Data.TableStorage;
using Microsoft.Extensions.DependencyInjection;

namespace AzureFunctionsCommomLibrary.Configurations;

public static class DependencyInjectionConfiguration
{
    public static IServiceCollection AddDependencyInjectionConfiguration(this IServiceCollection services)
    {
        services.AddScoped<IPlayerTableStorage, PlayerTableStorage>();
        return services;
    }
}
