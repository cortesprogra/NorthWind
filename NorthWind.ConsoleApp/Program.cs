
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;

//IUserActionWriter Writer = new ConsoleWriter();
IUserActionWriter Writer = new DebugWriter();

AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Application started.");

ProductService Product = new ProductService(Writer);
Product.Add("Demo", "Azúcar refinada.");
