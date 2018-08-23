using System;
using FluentAssertions;
using NSubstitute;
using UOM.Domain.Model.Dimensions;
using Xunit;

namespace UOM.Application.Tests.Unit
{
    public class DimensionServiceTests
    {
        [Fact]
        public void Create_should_add_dimension_to_repository()
        {
            const string time = "Time";
            var dto = new CreateDimensionDTO { Name = time };
            var repository = Substitute.For<IDimensionRepository>();
            var service = new DimensionService(repository);
            var expectedDimension = new Dimension(1, time);

            service.Create(dto);

            repository.Received(1).Add(expectedDimension);
        }
    }
}
