using Microsoft.Extensions.DependencyInjection;
using NorthWind.Core.Services;
using NorthWind.Entities.Interfaces;

namespace NorthWind.Core;

// La idea de crear esta clase es para decir: yo soy el implementador, nadie tien que saber qué es lo que hago.
public static class DependencyContainer
{
    // Acá se podría consolidar entonces todos los servicios que requiera mi aplicación.
    public static IServiceCollection AddMyServices(this IServiceCollection services)
    {
        // Por ejemplo solo registrar el DebugWriter (¿para qué quiero todos?)
        services.AddSingleton<IAppLogger, AppLogger>();
        services.AddSingleton<IProductService, ProductService>();
        return services;
    }

}
