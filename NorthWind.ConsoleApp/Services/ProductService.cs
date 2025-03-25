using NorthWind.Entities.ValueObjects;

namespace NorthWind.ConsoleApp.Services
{
    public class ProductService(IUserActionWriter Writer)
    {
        public void Add(string user, string productName)
        {
            UserAction Action = new UserAction(user, $"Created:{productName}");
            Writer.Write( Action );
        }
    }
}
