using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Application;
using ProductManagement.Application.Contracts;
using ProductManagement.Domain.Model.Product;

namespace ProductManagement.Application
{
    public class GenericProductCommandHandlers : ICommandHandler<CreateGenericProductCommand>
    {
        public void Handle(CreateGenericProductCommand command)
        {
            var constraints = ConstraintFactory.CreateFromDto(command.Constraints);
            var genericProduct = new GenericProduct(0, command.Name, constraints);

            //save generic product !
        }
    }
}
