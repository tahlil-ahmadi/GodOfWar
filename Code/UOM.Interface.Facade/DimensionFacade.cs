using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Application;
using Framework.Core.EventHandling;
using UOM.Application.Contracts;
using UOM.Domain.Contracts;
using UOM.Interface.Facade.Contracts;

namespace UOM.Interface.Facade
{
    public class DimensionFacade : IDimensionFacade
    {
        private readonly ICommandBus _commandBus;
        private readonly IEventListener _listener;
        public DimensionFacade(ICommandBus commandBus, IEventListener listener)
        {
            _commandBus = commandBus;
            _listener = listener;
        }

        public Guid Create(CreateDimensionCommand command)
        {
            var id = Guid.Empty;
            this._listener.Subscribe(new ActionHandler<DimensionCreated>(a =>
            {
                id = a.Id;
            }));
            _commandBus.Dispatch(command);
            return id;
        }
    }
}
