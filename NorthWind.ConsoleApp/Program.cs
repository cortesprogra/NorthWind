// 1. PROCESO DE PREPARACIÓN, SE LE DICE CUÁLES SON LOS SERVICIOS QUE VAMOS A USAR
// creame un application builder para manejar las dependencias por mi.
using Microsoft.Extensions.Dependency.Injection;

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();

// Ahora se agregan todos los servicios registrados para mi aplicación.
Builder.Services.AddNorthWindServices();

// Cuando te pida una instancia de AppLogger, devuelve una instancia de él mismo (no tiene abstracción).
Builder.Services.AddSingleton<AppLogger>();
Builder.Services.AddSingleton<ProductService>();

// Ahora sí, construye el Host de la aplicación.
using IHost AppHost = Builder.Build();

// 2. CONSUMIR LOS SERVICIOS ANTES INDICADOS
AppLogger Logger = AppHost.Services.GetRequiredService<AppLogger>();
Logger.WriteLog("Application started.");

ProductService Product = AppHost.Services.GetRequiredService<ProductService>();
Product.Add("Demo", "Azúcar refinada.");

/*
 * AppLogger y los Writers: Han implementando el principio de responsabilidad única.
 * AppLogger: Abierto pero cerrado
 * AppLogger: Inversión de dependencias, los módulos de alto nivel son independientes de los detalles de implementación. Depende de la abstracción pero independiente de la implementación.
 */
