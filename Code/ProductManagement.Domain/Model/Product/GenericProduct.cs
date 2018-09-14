using System.Collections.Generic;
using ProductManagement.Domain.Model.Constraints;

namespace ProductManagement.Domain.Model.Product
{
    public class GenericProduct : Product
    {
        public GenericProduct(string name, Product parent, List<PropertyConstraint> propertyConstraints) : base(name, parent, propertyConstraints)
        {
        }
    }
}
