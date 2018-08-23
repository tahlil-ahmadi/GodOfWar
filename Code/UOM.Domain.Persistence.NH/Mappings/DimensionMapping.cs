using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode.Conformist;
using UOM.Domain.Model.Dimensions;

namespace UOM.Domain.Persistence.NH.Mappings
{
    public class DimensionMapping : ClassMapping<Dimension>
    {
        public DimensionMapping()
        {
            Table("Dimensions");
            Id(a=>a.Id);
            Property(a=>a.Name);
        }
    }
}
