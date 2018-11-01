using System;
using System.Collections.Generic;
using FluentAssertions;
using ProductManagement.Domain.Model.Constraints;
using ProductManagement.Domain.Model.Product;
using ProductManagement.Domain.Model.Product.ProductConstraints;
using Xunit;

namespace ProductManagement.Domain.Tests.Unit
{
    public class GenericProductTests
    {
        [Fact]
        public void Constructor_should_create_root_product()
        {
            var id = 1;
            var name = "Nectar";
            var constraints = GetSomeValidConstraints();

            var product = new GenericProduct(id, name, constraints);

            product.Name.Should().Be(name);
            product.Id.Should().Be(id);
            product.Constraints.Should().BeEquivalentTo(constraints);
        }

        [Fact]
        public void Constructor_should_throw_exception_when_product_constraint_is_duplicated()
        {
            var id = 1;
            var name = "Clock";
            var constraints = GetSomeDuplicateConstraints();

            Action constructor = ()=> new GenericProduct(id, name, constraints);

            constructor.Should().Throw<DuplicateProductConstraintException>();
        }

        //TODO: move to a test util
        // anonymous creation method
        private static List<ProductConstraint> GetSomeDuplicateConstraints()
        {
            return new List<ProductConstraint>()
            {
                new NumberRangeConstraint(1,0,10),
                new NumberRangeConstraint(1,0,10),
                new StringConstraint(2,255),
            };
        }

        private static List<ProductConstraint> GetSomeValidConstraints()
        {
            return new List<ProductConstraint>()
            {
                new NumberRangeConstraint(1,0,10),
                new StringConstraint(2,255),
            };
        }
    }
}
