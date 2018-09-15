using System;
using FluentAssertions;
using Xunit;

namespace ProductManagement.Domain.Tests.Unit.ProductTests
{
    public class ActualProductTests
    {
        private readonly ActualProductBuilder _actualProductBuilder;
        public ActualProductTests()
        {
            _actualProductBuilder = new ActualProductBuilder();
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Constructor_should_throw_when_productName_is_wrong(string name)
        {
            Action product = () => _actualProductBuilder.WithRootProduct(name).Build();
            product.Should().Throw<Exception>();
        }

        [Fact]
        public void Constructor_should_throw_when_parent_isnot_genericproduct()
        {
            var productname = "";
            Action actualproduct = () => _actualProductBuilder.WithActualProductParent(productname).Build();
            actualproduct.Should().Throw<Exception>();
        }
    }
}
