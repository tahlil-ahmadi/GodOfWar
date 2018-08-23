using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOM.Domain.Model.Dimensions
{
    public interface IDimensionRepository
    {
        void Add(Dimension dimension);
    }
}
