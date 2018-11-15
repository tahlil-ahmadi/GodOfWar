using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.Logging
{
    public interface ILogger
    {
        void Error(Exception ex);
        void Info(string template, string[] parameters);
        void Warn(string template, string[] parameters);
        //...
    }
}
