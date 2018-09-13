using System;
using Framework.Core;

namespace Framework.Application
{
    public class CommandBus : ICommandBus
    {
        private readonly IServiceLocator _serviceLocator;
        public CommandBus(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public void Dispatch<T>(T command)
        {
            var handler = _serviceLocator.GetInstance<ICommandHandler<T>>();
            try
            {
                handler.Handle(command);
            }
            finally
            {
                _serviceLocator.Release(handler);
            }
        }
    }
}