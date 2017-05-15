using log4net;
using System;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Log4netHelper
{
    public class LogHelper
    {
        private static ILog _Ilog = null;

        private LogHelper(Type t)
        {
            _Ilog = log4net.LogManager.GetLogger(t);
        }

        public static LogHelper Create(Type t)
        {
            return new LogHelper(t);
        }

        public void Info(object message)
        {
            _Ilog.Info(message);
        }

        public void Info(object message, Exception ex)
        {
            _Ilog.Info(message, ex);
        }

        public void Error(object message)
        {
            _Ilog.Error(message);
        }

        public void Error(object message, Exception ex)
        {
            _Ilog.Error(message, ex);
        }

    }
}
