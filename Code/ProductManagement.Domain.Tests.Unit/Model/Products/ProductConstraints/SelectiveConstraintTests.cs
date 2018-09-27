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
            var fuelType = new Constraint {Id = 1, Title = "FuelType"};
            var pet = new Option("Petrolium",1);
            var gas = new Option("Gasoline",2);
            var options = new List<Option>() {pet,gas};

            var constraint = new SelectiveConstraint(fuelType, options);

            constraint.ConstraintId.Should().Be(fuelType.Id);
            constraint.Options.Should().BeEquivalentTo(options);
        }

        [Fact]
        public void Constructor_should_throw_if_options_have_duplicate_values()
        {
            var fuelType = new Constraint { Id = 1, Title = "FuelType" };
            var pet = new Option("Petrolium", 1);
            var gas = new Option("Gasoline", 1);
            var options = new List<Option>() { pet, gas };

            Action constructor = ()=> new SelectiveConstraint(fuelType, options);

            constructor.Should().Throw<DuplicateOptionException>();
        }
    }
}
