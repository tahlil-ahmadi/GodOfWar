using System.Collections.Generic;
using ProductManagement.Domain.Model.Constraints;
using ProductManagement.Domain.Model.Product;
using Xunit;

namespace ProductManagement.Domain.Tests.Unit
{
    public class ActualProductTests
    {
        private readonly ActualProductBuilder _actualProductBuilder;
        public ActualProductTests()
        {
            _actualProductBuilder = new ActualProductBuilder();
        }

        [Fact]
        public void Constructor_should_throw_exception_when_parent_isnot_genericproduct()
        {
            var productname = "";
            var actualproduct = _actualProductBuilder.WithActualProductParentNoProperty(productname);

        }
    }

    internal class ActualProductBuilder
    {
        private string Name { get; set; }
        private Product Parent { get; set; }
        private List<PropertyConstraint> PropertyConstraints { get; set; }

        public Product Build()
        {
            return new Product(Name, Parent, PropertyConstraints);
        }

        public ActualProductBuilder WithRootProduct(string productname)
        {
            Name = productname;
            Parent = null;
            return this;
        }

        public ActualProductBuilder WithRootProductNoProperty(string productname)
        {
            Name = productname;
            Parent = null;
            PropertyConstraints = null;
            return this;
        }

        public ActualProductBuilder WithActualProductParentNoProperty(string productname)
        {
            Name = productname;
            Parent = new ActualProduct("", null, null);
            PropertyConstraints = null;
            return this;
        }
    }
}
