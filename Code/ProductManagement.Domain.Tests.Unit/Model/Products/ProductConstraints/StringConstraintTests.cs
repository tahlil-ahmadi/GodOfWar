using FluentAssertions;
using Xunit;
using System;
using ProductManagement.Domain.Model.Product.ProductConstraints;

namespace ProductManagement.Domain.Tests.Unit.Model.Products.ProductConstraints
{
    public class StringConstraintTests
    {
        private readonly ConstraintBuilder _constraintBuilder;
        private readonly StringConstraintBuilder _stringConstraintBuilder;

        public StringConstraintTests()
        {
            _constraintBuilder = new ConstraintBuilder();
            _stringConstraintBuilder = new StringConstraintBuilder();
        }

        [Fact]
        public void Constructor_should_create_string_constraint()
        {
            var constraintId = 100;
            var constraintTitle = "description";
            var maxlen = 12;
            var format = "National Code";
            var constraint = _constraintBuilder.WithId(constraintId).WithTitle(constraintTitle).Build();
            var stringconstraint = _stringConstraintBuilder.WithFormat(format).WithMaxLength(maxlen).WithConstraint(constraint).Build();

            stringconstraint.ConstraintId.Should().Be(constraintId);
            stringconstraint.Format.Should().Be(format);
            stringconstraint.MaxLength.Should().Be(maxlen);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Constructor_should_throw_when_maxLength_lower_than_zero(long maxlen)
        {
            var format = "National Code";
            var constraint = _constraintBuilder.Build();

            Action stringconstraint = () => _stringConstraintBuilder.WithFormat(format).WithMaxLength(maxlen).WithConstraint(constraint).Build();

            stringconstraint.Should().Throw<MaxLengthException>();
        }
    }
}
