
using System.Collections.Generic;

namespace ProductManagement.Domain.Model.Product
{
    public class Package : Product
    {
        public List<Product> Products { get; set; }

        public Package(string name, Product parent) : base(name,parent)
        {
            
        }
    }
}
