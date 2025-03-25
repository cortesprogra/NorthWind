using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;

namespace NorthWind.Core.Services
{
    internal class AppLogger(IEnumerable<IUserActionWriter> writers) : IAppLogger
    {
        public void WriteLog(string message)
        {
            UserAction Log = new UserAction("System", message);
            foreach (IUserActionWriter writer in writers)
                writer.Write(Log);
        }
    }
}
