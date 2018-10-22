using Framework.Application;
using ProductManagement.Application.Contract;

namespace ProductManagement.Application
{
    public class ProductCommandHandler : ICommandHandler<CreateProductCommand>
    {
        public void Handle(CreateProductCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}
