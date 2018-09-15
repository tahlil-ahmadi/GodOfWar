using System.Collections.Generic;
using ProductManagement.Domain.Model.Constraints;

namespace ProductManagement.Domain.Model.Product
{
    public class Package : Product
    {
        public List<Product> Products { get; set; }

        public Package(long id, string name, Product parent, List<PropertyConstraint> propertyConstraints) 
            : base(id, name,parent, propertyConstraints)
        {
            
        }
    }
}
