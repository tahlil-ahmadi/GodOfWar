using System;
using FluentAssertions;
using ProductManagement.Domain.Model.Properties;
using Xunit;

namespace ProductManagement.Domain.Tests.Unit
{
    public class PropertyTests
    {
        [Fact]
        public void Constructor_should_create_property()
        {
            var propertyname = "Color";
            var property = new Property(propertyname);
            property.Name.Should().Be(propertyname);
        }

        [Fact]
        public void Constructor_should_throw_exception_when_propertyName_isnull()
        {
            var propertyname = "";
            var property = new Property(propertyname);
            var t = new Action(() => property.Validate(propertyname));
            t.Should().Throw<Exception>();
        }
    }
}
