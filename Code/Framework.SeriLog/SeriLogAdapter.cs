using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core.Logging;
using Serilog.Events;

namespace Framework.SeriLog
{
    public class SeriLogAdapter : ILogger
    {
        private Serilog.ILogger _logger;
        public SeriLogAdapter(Serilog.ILogger logger)
        {
            this._logger = logger;
        }

        public void Error(Exception ex)
        {
            if (this._logger.IsEnabled(LogEventLevel.Error))
            {
                var message = ex.ToString();
                this._logger.Error(message);
            }
        }

        public void Info(string template, string[] parameters)
        {
            Write(LogEventLevel.Information, template, parameters);
        }
        public void Warn(string template, string[] parameters)
        {
            Write(LogEventLevel.Warning,template,parameters);
        }

        private void Write(LogEventLevel level, string template, string[] parameters)
        {
            if (this._logger.IsEnabled(level))
            {
                this._logger.Write(level,template, parameters);
            }
        }
    }
}
