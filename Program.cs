using System;
using log4net;
using System.Reflection;
using NLog;
using System.IO;

namespace console
{
    class Program
    {

        static void Main(string[] args)
        {
            var logRepository = log4net.LogManager.GetRepository(Assembly.GetEntryAssembly());
            log4net.Config.XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

            ILog log = log4net.LogManager.GetLogger(typeof(Program));
            log.Error("log4net");

            NLog.LogManager.Configuration = new NLog.Config.XmlLoggingConfiguration("nlog.config");

            var logger = NLog.LogManager.GetCurrentClassLogger();

            logger.Error("nlog");
        }
    }
}
