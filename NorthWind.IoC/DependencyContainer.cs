﻿using Microsoft.Extensions.DependencyInjection;
using NorthWind.Core;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;

namespace NorthWind.IoC;

// La idea de crear esta clase es para decir: yo soy el implementador, nadie tien que saber qué es lo que hago.
public static class DependencyContainer
{
    // Acá se podría consolidar entonces todos los servicios que requiera mi aplicación.
    public static IServiceCollection AddNorthWindServices(this IServiceCollection services)
    {
        // Por ejemplo solo registrar el DebugWriter (¿para qué quiero todos?)
        services.AddDebugWriter();
        services.AddMyServices();
        return services;
    }

}
