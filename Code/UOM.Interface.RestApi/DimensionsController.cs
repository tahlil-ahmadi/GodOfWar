using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Framework.Application;
using Framework.Core;
using Framework.Core.EventHandling;
using UOM.Application;
using UOM.Application.Contracts;
using UOM.Domain.Contracts;
using UOM.Query.Model.Models;
using UOM.Query.Model.Repositories;

namespace UOM.Interface.RestApi
{
    public class DimensionsController : ApiController, IGateway
    {
        private readonly ICommandBus _commandBus;
        private readonly IEventListener _listener;
        private readonly IEventPublisher _publisher;

        public DimensionsController(ICommandBus commandBus, IEventListener listener,
            IEventPublisher publisher)
        {
            _commandBus = commandBus;
            _listener = listener;
            _publisher = publisher;
        }

        public Guid Post(CreateDimensionCommand command)
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
