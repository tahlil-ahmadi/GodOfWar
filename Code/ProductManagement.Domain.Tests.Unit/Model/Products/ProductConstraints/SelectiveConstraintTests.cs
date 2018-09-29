using System;
using FluentAssertions;
using ProductManagement.Domain.Model.Product.ProductConstraints;
using Xunit;

namespace ProductManagement.Domain.Tests.Unit.Model.Products.ProductConstraints
{
    public class SelectiveConstraintTests
    {
        private readonly ConstraintBuilder _constraintBuilder;
        private readonly OptionBuilder _optionBuilder;

        public SelectiveConstraintTests()
        {
            _constraintBuilder = new ConstraintBuilder();
            _optionBuilder =  new OptionBuilder();
        }

        [Fact]
        public void Constructor_should_create_selective_constraint()
        {
            var constraintId = 25;
            var constraintTilte = "FuelType";

            var fuelType = _constraintBuilder.WithId(constraintId).WithTitle(constraintTilte).Build();
            var pet = _optionBuilder.WithTitle("Petrolium").WithValue(1).Build();
            var gas = _optionBuilder.WithTitle("Gasoline").WithValue(2).Build();
            var options = _optionBuilder.BuildListOptionsFrom(pet, gas);

            var constraint = new SelectiveConstraint(fuelType, options);

            constraint.ConstraintId.Should().Be(fuelType.Id);
            constraint.Options.Should().BeEquivalentTo(options);
        }

        [Fact]
        public void Constructor_should_throw_if_options_have_duplicate_values()
        {
            var fuelType = _constraintBuilder.Build();
            var pet = _optionBuilder.WithTitle("Petrolium").WithValue(1).Build();
            var gas = _optionBuilder.WithTitle("Gasoline").WithValue(1).Build();
            var options = _optionBuilder.BuildListOptionsFrom(pet, gas);

            Action constructor = ()=> new SelectiveConstraint(fuelType, options);

            constructor.Should().Throw<DuplicateOptionException>();
        }
    }
}
