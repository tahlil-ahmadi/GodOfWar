using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Application;
using UOM.Application.Contracts;
using UOM.Domain.Model.Dimensions;

namespace UOM.Application
{
    public class DimensionCommandHandlers : ICommandHandler<CreateDimensionCommand>,
                                            ICommandHandler<ModifyDimensionCommand>
    {
        private readonly IDimensionRepository _repository;
        public DimensionCommandHandlers(IDimensionRepository repository)
        {
            _repository = repository;
        }

        public void Handle(CreateDimensionCommand command)
        {
            var dimension = new Dimension(command.Name);
            _repository.Add(dimension);
        }

        public void Handle(ModifyDimensionCommand command)
        {
            //....
        }
    }
}
