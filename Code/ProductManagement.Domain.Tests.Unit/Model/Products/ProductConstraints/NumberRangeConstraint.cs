using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using ProductManagement.Domain.Model.Product.ProductConstraints;
using Xunit;

namespace ProductManagement.Domain.Tests.Unit.Model.Products.ProductConstraints
{
    public class NumberRangeConstraintTests
    {
        [Fact]
        public void Should_be_constructed_properly()
        {
            var constraintId = 1;
            var min = 10;
            var max = 1000;

            var constraint = new NumberRangeConstraint(constraintId, min, max);

            constraint.ConstraintId.Should().Be(constraintId);
            constraint.Max.Should().Be(max);
            constraint.Min.Should().Be(min);
        }

        [Fact]
        public void Should_throw_if_max_is_smaller_than_min()
        {
            var constraintId = 1;
            var min = 100;
            var max = 50;

            Action constructor = ()=> new NumberRangeConstraint(constraintId, min, max);

            constructor.Should().Throw<ArgumentException>();
        }
        
        [Theory]
        [InlineData(1, 10, 5, true)]
        [InlineData(1, 10, 10, true)]
        [InlineData(1, 10, 1, true)]
        [InlineData(1, 10, 11, false)]
        [InlineData(1, 10, -1, false)]
        [InlineData(null, 10, 9, true)]
        [InlineData(1, null, 9, true)]
        [InlineData(null, null, 100, true)]
        public void Validate_should_validate_characteristic_value_based_on_range(int? min, int? max, int value, bool expectedResult)
        {
            var constraintId = 1;
            var constraint = new NumberRangeConstraint(constraintId, min,max);

            var result = constraint.Validate(value);

            result.Should().Be(expectedResult);
        }
    }
}
