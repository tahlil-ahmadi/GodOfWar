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
using UOM.Query.Model.Models;
using UOM.Query.Model.Repositories;

namespace UOM.Interface.RestApi
{
    public class DimensionsController : ApiController, IGateway
    {
        private readonly ICommandBus _commandBus;
        public DimensionsController(ICommandBus commandBus)
        {
            _commandBus = commandBus;
        }

        public void Post(CreateDimensionCommand command)
        {
            _commandBus.Dispatch(command);
        }
    }
}
