using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Application.Decorators
{
    public class LoggerCommandHandlerDecorator<T> : ICommandHandler<T>
    {
        private readonly ICommandHandler<T> _targetHandler;
        public LoggerCommandHandlerDecorator(ICommandHandler<T> targetHandler)
        {
            _targetHandler = targetHandler;
        }

        public void Handle(T command)
        {
            Debug.Write("*********");
            _targetHandler.Handle(command);
            Debug.Write("*********");
        }
    }
}
