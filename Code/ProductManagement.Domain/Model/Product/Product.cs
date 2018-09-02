using Framework.Domain;

namespace ProductManagement.Domain.Model.Product
{
    public class Product : AggregateRoot<long>
    {
        public string Name { get; private set; }
        public Product Parent { get; private set; }

        public Product(string name, Product parent)
        {
            Name = name;
            Parent = parent;
        }
    }
}
