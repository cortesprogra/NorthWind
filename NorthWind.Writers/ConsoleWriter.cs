using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;

namespace NorthWind.Writers
{
    public class ConsoleWriter : IUserActionWriter
    {
        public void Write(UserAction action)
        {
            Console.WriteLine("Console Writer: {0}, {1}, {2}",
                action.CreatedDateTime, action.User, action.Description);
        }
    }
}
