using System.Web.Http;
using Framework.Application;
using ProductManagement.Application.Contract;

namespace ProductManagement.Interface.RestApi
{
    public class ProductController : ApiController
    {
        private readonly ICommandBus _commandBus;

        public ProductController(ICommandBus commandBus)
        {
            _commandBus = commandBus;
        }

        public void Post(CreateProductCommand command)
        {
            _commandBus.Dispatch(command);
        }
    }
}
