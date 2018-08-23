using Framework.Domain;

namespace UOM.Domain.Model.UnitOfMeasures
{
    public abstract class UnitOfMeasure : AggregateRoot<IsoCode>
    {
        public string Name { get; private set; }
        protected UnitOfMeasure(string name, string isoCode)
        {
            Id = new IsoCode(isoCode);
            Name = name;
        }
    }
}