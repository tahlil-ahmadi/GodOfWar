using System;
using FluentAssertions;
using Xunit;

namespace ProductManagement.Domain.Tests.Unit.PropertyTests
{
    public class PropertyTests
    {
        private readonly PropertyBuilder _propertyBuilder;
        public PropertyTests()
        {
            _propertyBuilder = new PropertyBuilder();
        }

        [Fact]
        public void Constructor_should_create_property()
        {
            var propertyname = "Color";
            var property = _propertyBuilder.WithName(propertyname).Build();
            property.Name.Should().Be(propertyname);
        }

        [Fact]
        public void Constructor_should_throw_when_propertyName_isnull()
        {
            Action property = () => _propertyBuilder.WithName(null).Build();
            property.Should().Throw<Exception>();
        }

        [Fact]
        public void Constructor_should_throw_when_propertyName_is_empty()
        {
            Action property = () => _propertyBuilder.WithName("").Build();
            property.Should().Throw<Exception>();
        }
    }
}
