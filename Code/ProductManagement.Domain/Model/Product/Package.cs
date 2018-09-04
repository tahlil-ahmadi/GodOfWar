
using System.Collections.Generic;
using ProductManagement.Domain.Model.Properties;

namespace ProductManagement.Domain.Model.Product
{
    public class Package : Product
    {
        public List<Product> Products { get; set; }

        public Package(string name, Product parent, List<Property> properties) : base(name,parent, properties)
        {
            
        }
    }
}
