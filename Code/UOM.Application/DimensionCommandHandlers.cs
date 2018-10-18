using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Application;
using Framework.Core.EventHandling;
using UOM.Application.Contracts;
using UOM.Domain.Model.Dimensions;

namespace UOM.Application
{
    public class DimensionCommandHandlers : ICommandHandler<CreateDimensionCommand>,
                                            ICommandHandler<ModifyDimensionCommand>
    {
        private readonly IDimensionRepository _repository;
        private readonly IEventPublisher _publisher;
        public DimensionCommandHandlers(IDimensionRepository repository, IEventPublisher publisher)
        {
            _repository = repository;
            _publisher = publisher;
        }

        public void Handle(CreateDimensionCommand command)
        {
            var dimension = new Dimension(command.Name, this._publisher);
            _repository.Add(dimension);
        }

        public void Handle(ModifyDimensionCommand command)
        {
            //....
        }
    }
}
