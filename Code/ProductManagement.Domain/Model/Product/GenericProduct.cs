using System.Collections.Generic;
using ProductManagement.Domain.Model.Properties;

namespace ProductManagement.Domain.Model.Product
{
    public class GenericProduct : Product
    {
        public GenericProduct(string name, Product parent, List<Property> properties) : base(name, parent, properties)
        {
        }
    }
}
