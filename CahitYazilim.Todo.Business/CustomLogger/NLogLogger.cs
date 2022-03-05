using NLog;
using CahitYazilim.Todo.Business.Interfaces;

namespace CahitYazilim.Todo.Business.CustomLogger
{
    public class NLogLogger : ICustomLogger
    {
        public void LogError(string message)
        {
            var logger = LogManager.GetLogger("loggerFile");
            logger.Log(LogLevel.Error, message);
        }
    }
}
