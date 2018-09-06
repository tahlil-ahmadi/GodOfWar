using System.Collections.Generic;
using Framework.Domain;
using ProductManagement.Domain.Model.Properties;

namespace ProductManagement.Domain.Model.Product
{
    public class Product : AggregateRoot<long>
    {
        public string Name { get; private set; }
        public Product Parent { get; private set; }

        public List<Property> Properties { get; private set; }

        public Product(string name, Product parent, List<Property> properties)
        {
            Name = name;
            Parent = parent;
            Properties = properties;
        }
    }
}
