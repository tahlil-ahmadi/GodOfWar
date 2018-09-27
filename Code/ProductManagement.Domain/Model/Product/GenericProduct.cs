using System.Collections.Generic;

namespace ProductManagement.Domain.Model.Product
{
    public class GenericProduct : Product
    {
        public GenericProduct(string name) : base(name)
        {
        }
        public GenericProduct(string name, GenericProduct parentProduct) 
            : base(name, parentProduct)
        {
        }
    }
}
