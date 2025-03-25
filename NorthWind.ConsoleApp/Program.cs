// 1. PROCESO DE PREPARACIÓN, SE LE DICE CUÁLES SON LOS SERVICIOS QUE VAMOS A USAR
// creame un application builder para manejar las dependencias por mi.

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();

// Ahora se agregan todos los servicios registrados para mi aplicación.
Builder.Services.AddNorthWindServices();

// Ahora sí, construye el Host de la aplicación.
using IHost AppHost = Builder.Build();

// 2. CONSUMIR LOS SERVICIOS ANTES INDICADOS
IAppLogger Logger = AppHost.Services.GetRequiredService<IAppLogger>();
Logger.WriteLog("Application started.");

IProductService Product = AppHost.Services.GetRequiredService<IProductService>();
Product.Add("Demo", "Azúcar refinada.");

/*
 * AppLogger y los Writers: Han implementando el principio de responsabilidad única.
 * AppLogger: Abierto pero cerrado
 * AppLogger: Inversión de dependencias, los módulos de alto nivel son independientes de los detalles de implementación. Depende de la abstracción pero independiente de la implementación.
 */
