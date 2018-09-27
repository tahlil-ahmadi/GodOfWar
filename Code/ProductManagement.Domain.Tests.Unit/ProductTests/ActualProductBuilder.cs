using System.Collections.Generic;
using ProductManagement.Domain.Model.Constraints;
using ProductManagement.Domain.Model.Product;

namespace ProductManagement.Domain.Tests.Unit.ProductTests
{
    internal class ActualProductBuilder
    {
        private long _id;
        private string _name;
        private Product _parent;
        private List<PropertyConstraint> _propertyConstraints;

        public Product Build()
        {
            return new Product(_id,_name, _parent, _propertyConstraints);
        }

        public ActualProductBuilder WithRootProduct(string productname)
        {
            _id = 0;
            _name = productname;
            _parent = null;
            return this;
        }
        
        public ActualProductBuilder WithActualProductParent()
        {
            _parent = new ActualProduct(0,"", null, null);
            return this;
        }
    }
}