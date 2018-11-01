using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Application.Contracts
{
    public class StringProductConstraintDto : ProductConstraintDto
    {
        public long MaxLength { get; set; }
        public string Format { get; set; }
    }
}
