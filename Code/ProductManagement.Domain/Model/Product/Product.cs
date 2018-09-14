using System.Collections.Generic;
using Framework.Domain;
using ProductManagement.Domain.Model.Constraints;

namespace ProductManagement.Domain.Model.Product
{
    public class Product : AggregateRoot<long>
    {
        public string Name { get; private set; }
        public Product Parent { get; private set; }

        public List<PropertyConstraint> PropertyConstraints { get; private set; }

        public Product(string name, Product parent, List<PropertyConstraint> propertyConstraints)
        {
            Name = name;
            Parent = parent;
            PropertyConstraints = propertyConstraints;
        }
    }
}
