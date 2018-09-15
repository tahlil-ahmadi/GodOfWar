using System;
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

        public Product(long id, string name, Product parent, List<PropertyConstraint> propertyConstraints)
        {
            Validate(name);
            Id = id;
            Name = name;
            Parent = parent;
            PropertyConstraints = propertyConstraints;
        }

        private void Validate(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Product name could not be null or empty.");
        }
    }
}
