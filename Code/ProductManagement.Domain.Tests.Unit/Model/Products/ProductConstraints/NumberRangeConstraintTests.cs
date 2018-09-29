using FluentAssertions;
using Xunit;

namespace ProductManagement.Domain.Tests.Unit.Model.Products.ProductConstraints
{
    public class NumberRangeConstraintTests
    {
        private readonly ConstraintBuilder _constraintBuilder;
        private readonly NumberRangeConstraintBuilder _numberRangeBuilder;

        public NumberRangeConstraintTests()
        {
            _constraintBuilder = new ConstraintBuilder();
            _numberRangeBuilder = new NumberRangeConstraintBuilder();
        }

        [Fact]
        public void Constructor_should_create_number_range_constraint()
        {
            var constraintId = 33;
            decimal? min = null;
            decimal? max = null;
            var constraint = _constraintBuilder.WithId(constraintId).Build();

            var numberRange = _numberRangeBuilder.WithMax(max).WithMin(min).WithConstraint(constraint).Build();

            numberRange.ConstraintId.Should().Be(constraintId);
            numberRange.Min.Should().Be(min);
            numberRange.Max.Should().Be(max);
        }   
    }
}
