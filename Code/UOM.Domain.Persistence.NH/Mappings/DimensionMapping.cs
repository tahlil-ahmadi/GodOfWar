using NHibernate.Mapping.ByCode.Conformist;
using UOM.Domain.Model.Dimensions;

namespace UOM.Persistence.NH.Mappings
{
    public class DimensionMapping : ClassMapping<Dimension>
    {
        public DimensionMapping()
        {
            Table("Dimensions");
            Lazy(false);
            Id(a=>a.Id);
            Property(a=>a.Name);
        }
    }
}
