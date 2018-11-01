using System.Collections.Generic;

namespace ProductManagement.Application.Contracts
{
    public class CreateGenericProductCommand
    {
        public string Name { get; set; }
        public List<ProductConstraintDto> Constraints { get; set; }
    }
}