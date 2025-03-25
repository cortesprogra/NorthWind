
using Microsoft.Extensions.DependencyInjection;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;

namespace Microsoft.Extensions.Dependency.Injection;

// La idea de crear esta clase es para decir: yo soy el implementador, nadie tien que saber qué es lo que hago.
public static class DependencyContainer
{
    public static IServiceCollection AddConsoleWriter(this IServiceCollection services)
    {
        services.AddSingleton<IUserActionWriter, ConsoleWriter>();
        return services;
    }

    public static IServiceCollection AddDebugWriter(this IServiceCollection services)
    {
        services.AddSingleton<IUserActionWriter, DebugWriter>();
        return services;
    }

    public static IServiceCollection AddFileWriter(this IServiceCollection services)
    {
        services.AddSingleton<IUserActionWriter, FileWriter>();
        return services;
    }
}
