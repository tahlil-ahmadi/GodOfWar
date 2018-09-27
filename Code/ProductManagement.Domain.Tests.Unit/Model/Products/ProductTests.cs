using FluentAssertions;
using ProductManagement.Domain.Model.Product;
using Xunit;

namespace ProductManagement.Domain.Tests.Unit
{
    public class ProductTests
    {
        #region HelperClasses
        private class DummyProduct : Product
        {
            public DummyProduct(string name)
                : base(name)
            {
            }

            public DummyProduct(string name, GenericProduct parentProduct) 
                : base(name, parentProduct)
            {
            }
        }
        #endregion

        [Fact]
        public void Constructor_should_create_root_product()
        {
            var name = "Nectar";

            var product = new DummyProduct(name);

            product.Name.Should().Be(name);
            product.ParentProductId.Should().BeNull();
        }

        [Fact]
        public void Constructor_should_create_child_product()
        {
            var nectarName = "Nectar";
            var orangeNectarName = "Orange Nectar";

            var nectar = new GenericProduct(nectarName);
            var product = new DummyProduct(orangeNectarName, nectar);

            product.Name.Should().Be(orangeNectarName);
            product.ParentProductId.Should().Be(nectar.Id);     //TODO: it has no Id :|
        }
    }
}
