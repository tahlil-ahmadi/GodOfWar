using System.Collections.Generic;
using ProductManagement.Domain.Model.Constraints;

namespace ProductManagement.Domain.Model.Product
{
    public class GenericProduct : Product
    {
        public GenericProduct(long id, string name, Product parent, List<PropertyConstraint> propertyConstraints) 
            : base(id, name, parent, propertyConstraints)
        {
        }
    }
}
