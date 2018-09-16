using System;
using System.Collections.Generic;
using ProductManagement.Domain.Model.Constraints;

namespace ProductManagement.Domain.Model.Product
{
    public class ActualProduct : Product 
    {
        public ActualProduct(long id, string name,Product parent, List<PropertyConstraint> propertyConstraints) 
            : base(id, name, parent, propertyConstraints)
        {
            
        }
    }
}
