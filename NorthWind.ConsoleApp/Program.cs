
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;

//IUserActionWriter Writer = new ConsoleWriter();
//IUserActionWriter Writer = new DebugWriter();
IUserActionWriter Writer = new FileWriter();

AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Application started.");

ProductService Product = new ProductService(Writer);
Product.Add("Demo", "Azúcar refinada.");

/*
 * AppLogger y los Writers: Han implementando el principio de responsabilidad única.
 * AppLogger: Abierto pero cerrado
 * AppLogger: Inversión de dependencias, los módulos de alto nivel son independientes de los detalles de implementación. Depende de la abstracción pero independiente de la implementación.
 */
