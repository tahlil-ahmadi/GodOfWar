using System;
using FluentAssertions;
using Framework.Core.EventHandling;
using NSubstitute;
using UOM.Application.Contracts;
using UOM.Domain.Model.Dimensions;
using Xunit;

namespace UOM.Application.Tests.Unit
{
    public class DimensionCommandHandlerTests
    {
        [Fact]
        public void HandleCreate_should_add_dimension_to_repository()
        {
            const string time = "Time";
            var aggregate = new EventAggregator();
            var dto = new CreateDimensionCommand { Name = time };
            var repository = Substitute.For<IDimensionRepository>();
            var service = new DimensionCommandHandlers(repository, aggregate);
            var expectedDimension = new Dimension(time, aggregate);

            service.Handle(dto);

            repository.Received(1).Add(expectedDimension);
        }
    }
}
