using System;
using FluentAssertions;
using Xunit;

namespace ProductManagement.Domain.Tests.Unit.ProductTests
{
    public class ProductTests
    {
        private readonly ProductBuilder _productBuilder;
        public ProductTests()
        {
            _productBuilder = new ProductBuilder();
        }

        [Fact]
        public void Constructor_should_create_product()
        {
            var productname = "Soccer ball";
            var product = _productBuilder.WithRootProduct(productname).WithRootProductNoProperty().Build();
            product.Name.Should().Be(productname);
            product.Parent.Should().Be(null);
            product.PropertyConstraints.Should().BeNull();
        }


        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Constructor_should_throw_when_productName_is_wrong(string name)
        {
            Action product = () => _productBuilder.WithRootProduct(name).Build();
            product.Should().Throw<Exception>();
        }
    }
}
