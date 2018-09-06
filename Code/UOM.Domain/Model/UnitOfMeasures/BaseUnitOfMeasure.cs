using System;
using UOM.Domain.Model.Dimensions;

namespace UOM.Domain.Model.UnitOfMeasures
{
    public class BaseUnitOfMeasure : UnitOfMeasure
    {
        public Guid DimensionId { get; private set; }
        public BaseUnitOfMeasure(Dimension dimension, string name, string isoCode) 
            : base(name, isoCode)
        {
            this.DimensionId = dimension.Id;
        }
    }
}