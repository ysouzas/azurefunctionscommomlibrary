using AzureFunctionsCommomLibrary.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AzureFunctionsCommomLibrary.Configurations;

public static class ApiConfiguration
{
    public static IServiceCollection AddApiConfiguration(this IServiceCollection services, IConfiguration config)
    {
        services.Configure<TableStorageOptions>(config.GetSection(nameof(TableStorageOptions)));
        return services;
    }
}
