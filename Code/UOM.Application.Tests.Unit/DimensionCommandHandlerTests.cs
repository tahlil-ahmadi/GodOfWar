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

            var command = new CreateDimensionCommand { Name = time };
            var expectedDimension = new Dimension(time, aggregate);
            var repository = Substitute.For<IDimensionRepository>();
            var commandHandler = new DimensionCommandHandlers(repository, aggregate);

            commandHandler.Handle(command);

            repository.Received(1)
                    .Add(Verify.That<Dimension>(
                            a => a.Should().BeEquivalentTo(expectedDimension,
                                z => z.Excluding(b => b.Id).ComparingByMembers<Dimension>())));
        }
    }
}
