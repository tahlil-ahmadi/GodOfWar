using System.Collections.Generic;
using ProductManagement.Domain.Model.Constraints;
using ProductManagement.Domain.Model.Product;

namespace ProductManagement.Domain.Tests.Unit.ProductTests
{
    internal class ProductBuilder
    {
        private long _id;
        private string _name;
        private Product _parent;
        private List<PropertyConstraint> _propertyConstraints;

        public Product Build()
        {
            return new Product(_id,_name, _parent, _propertyConstraints);
        }

        public ProductBuilder WithRootProduct(string productname)
        {
            _id = 0;
            _name = productname;
            _parent = null;
            return this;
        }

        public ProductBuilder WithRootProductNoProperty()
        {
            _propertyConstraints = null;
            return this;
        }
    }
}