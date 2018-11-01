using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Framework.Application;
using Framework.Core;
using Newtonsoft.Json.Linq;
using ProductManagement.Application.Contracts;

namespace ProductManagement.Interface.RestApi
{
    public class GenericProductsController : ApiController, IGateway
    {
        private ICommandBus _bus;
        public GenericProductsController(ICommandBus bus)
        {
            _bus = bus;
        }

        public void Post(CreateGenericProductCommand command)
        {
            //TODO: use a model binder here and remove this hard-coded command initialization!
            command = new CreateGenericProductCommand()
            {
                Name = "X",
                Constraints = new List<ProductConstraintDto>()
                {
                    new NumericRangeConstraintDto()
                    {
                        ConstraintId = 1, Max = 10, Min = 1
                    },
                    new StringProductConstraintDto()
                    {
                        ConstraintId = 2, MaxLength = 255
                    }
                }
            };

            _bus.Dispatch(command);
        }
    }
}
