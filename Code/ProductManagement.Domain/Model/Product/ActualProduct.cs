using System.Collections.Generic;
using ProductManagement.Domain.Model.Properties;

namespace ProductManagement.Domain.Model.Product
{
    public class ActualProduct : Product 
    {
        public ActualProduct(string name, List<Property> properties) : base(name,null, properties)
        {
            
        }
    }
}
