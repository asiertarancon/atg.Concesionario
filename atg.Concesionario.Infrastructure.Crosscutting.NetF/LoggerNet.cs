using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atg.Concesionario.Infrastructure.Crosscutting.NetF
{
    public class LoggerNet : ILogger
    {
        readonly log4net.ILog _logger;
        public LoggerNet([System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
        {
            _logger = log4net.LogManager.GetLogger(memberName);
        }

        public void Debug(object item)
        {
            _logger.Debug(item);
        }

        public void Debug(string message, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Debug(string message, Exception exception, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message, Exception exception, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void LogError(string message, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void LogError(string message, Exception exception, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void LogInfo(string message, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void LogWarning(string message, params object[] args)
        {
            throw new NotImplementedException();
        }
    }
}
