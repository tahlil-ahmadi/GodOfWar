using System;
using System.Collections.Generic;
using ProductManagement.Domain.Model.Constraints;

namespace ProductManagement.Domain.Model.Product
{
    public class ActualProduct : Product 
    {
        public ActualProduct(string name,Product parent, List<PropertyConstraint> propertyConstraints) : base(name, parent, propertyConstraints)
        {
            if (parent.GetType() != typeof(GenericProduct))
            {
                throw new Exception("parent should be GenericProduct");
            }
        }
    }
}
