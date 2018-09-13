using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Framework.Application;
using UOM.Application;
using UOM.Application.Contracts;

namespace UOM.Interface.RestApi
{
    public class DimensionsController : ApiController
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
