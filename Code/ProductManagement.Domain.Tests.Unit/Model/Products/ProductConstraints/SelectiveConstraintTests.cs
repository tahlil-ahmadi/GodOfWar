using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using ProductManagement.Domain.Model.Constraints;
using ProductManagement.Domain.Model.Product.ProductConstraints;
using Xunit;

namespace ProductManagement.Domain.Tests.Unit.Model.Products.ProductConstraints
{
    public class SelectiveConstraintTests
    {
        //TODO: refactor this tests

        [Fact]
        public void Constructor_should_create_selective_constraint()
        {
            var fuelType = 1;
            var pet = new Option("Petroleum",1);
            var gas = new Option("Gasoline",2);
            var options = new List<Option>() {pet,gas};

            var constraint = new SelectiveConstraint(fuelType, options);

            constraint.ConstraintId.Should().Be(fuelType);
            constraint.Options.Should().BeEquivalentTo(options);
        }

        [Fact]
        public void Constructor_should_throw_if_options_have_duplicate_values()
        {
            var fuelType = 1;
            var pet = new Option("Petroleum", 1);
            var gas = new Option("Gasoline", 1);
            var options = new List<Option>() { pet, gas };

            Action constructor = ()=> new SelectiveConstraint(fuelType, options);

            constructor.Should().Throw<DuplicateOptionException>();
        }


        [Fact]
        public void Validate_should_return_true_if_value_present_in_keys()
        {
            var fuelType = 1;
            var pet = new Option("Petroleum", 1);
            var gas = new Option("Gasoline", 2);
            var options = new List<Option>() { pet, gas };
            var constraint = new SelectiveConstraint(fuelType, options);
            var value = 1;

            var result = constraint.Validate(value);

            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_should_return_false_if_value_is_not_present_in_keys()
        {
            var fuelType = 1;
            var pet = new Option("Petroleum", 1);
            var gas = new Option("Gasoline", 2);
            var options = new List<Option>() { pet, gas };
            var constraint = new SelectiveConstraint(fuelType, options);
            var value = 10;

            var result = constraint.Validate(value);

            result.Should().BeFalse();
        }
    }
}
