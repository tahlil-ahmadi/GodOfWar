using FluentAssertions;
using ProductManagement.Domain.Model.Product.ProductConstraints;
using Xunit;
using System;

namespace ProductManagement.Domain.Tests.Unit.Model.Products.ProductConstraints
{
    public class StringConstraintTests
    {
        private readonly ConstraintBuilder _constraintBuilder;
        public StringConstraintTests()
        {
            _constraintBuilder = new ConstraintBuilder();
        }

        [Fact]
        public void Constructor_should_create_string_constraint()
        {
            var constraintId = 100;
            var constraintTitle = "description";
            var maxlen = 12;
            var format = "National Code";
            var description = _constraintBuilder.WithId(constraintId).WithTitle(constraintTitle).Build();
            var stringconstraint = new StringConstraint(format,maxlen,description);

            stringconstraint.ConstraintId.Should().Be(description.Id);
            stringconstraint.Format.Should().Be(format);
            stringconstraint.MaxLength.Should().Be(maxlen);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Constructor_should_throw_when_maxLength_lower_than_zero(long maxlen)
        {
            var format = "National Code";
            var description = _constraintBuilder.Build();

            Action stringconstraint = () => new StringConstraint(format, maxlen, description);

            stringconstraint.Should().Throw<MaxLengthException>();
        }
    }
}
