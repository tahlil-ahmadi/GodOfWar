namespace UOM.Domain.Model.UnitOfMeasures
{
    public class ScaledUnitOfMeasure : UnitOfMeasure
    {
        public IsoCode BaseUnitOfMeasureCode { get; private set; }
        public decimal ConversionFactor { get; private set; }
        public ScaledUnitOfMeasure(BaseUnitOfMeasure baseUnitOfMeasure, string name, string isoCode, decimal conversionFactor) 
            : base(name, isoCode)
        {
            this.BaseUnitOfMeasureCode = baseUnitOfMeasure.Id;
            this.ConversionFactor = conversionFactor;
        }

        public decimal ConvertTo(ScaledUnitOfMeasure targetUnitOfMeasure, decimal amount)
        {
            var baseAmount = ConvertToBaseMeasurement(amount);
            return baseAmount * targetUnitOfMeasure.ConversionFactor;
        }

        public decimal ConvertToBaseMeasurement(decimal amount)
        {
            return amount / this.ConversionFactor;
        }
    }
}