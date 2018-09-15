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
            Action td = () => _propertyBuilder.WithName(null).Build();
            td.Should().Throw<Exception>();
        }

        [Fact]
        public void Constructor_should_throw_when_propertyName_is_empty()
        {
            Action td = () => _propertyBuilder.WithName("").Build();
            td.Should().Throw<Exception>();
        }
    }
}
