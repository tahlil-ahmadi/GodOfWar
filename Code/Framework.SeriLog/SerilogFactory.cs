using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using ILogger = Framework.Core.Logging.ILogger;

namespace Framework.SeriLog
{
    public static class SerilogFactory
    {
        public static ILogger CreateForRollingFile()
        {
            var log = new LoggerConfiguration()
                .WriteTo.RollingFile("log-{Date}.txt", fileSizeLimitBytes: 50000000)
                .CreateLogger();
            var adapter = new SeriLogAdapter(log);
            return adapter;
        }
    }
}
