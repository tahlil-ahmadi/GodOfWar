using System.Collections.Generic;
using Framework.Domain;
using ProductManagement.Domain.Model.Product.ProductConstraints;

namespace ProductManagement.Domain.Model.Product
{
    public abstract class Product : AggregateRoot<long>
    {
        public string Name { get;private set; }
        public long? ParentProductId { get;private set; }
        protected Product(string name) : this(name, null)
        {
        }
        protected Product(string name, GenericProduct parentProduct)
        {
            this.Name = name;
            if (parentProduct != null)
                this.ParentProductId = parentProduct.Id;
        }

        public void AddConstraint(ProductConstraint constraint)
        {
            //...
        }
    }
}
