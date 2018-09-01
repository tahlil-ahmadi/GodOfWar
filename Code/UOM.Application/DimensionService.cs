using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOM.Domain.Model.Dimensions;

namespace UOM.Application
{
	//This is a test
    public class DimensionService : IDimensionService
    {
        private readonly IDimensionRepository _repository;
        public DimensionService(IDimensionRepository repository)
        {
            _repository = repository;
        }

        public void Create(CreateDimensionDTO dto)
        {
            var dimension = new Dimension(1,dto.Name);
            _repository.Add(dimension);
        }
    }
}
