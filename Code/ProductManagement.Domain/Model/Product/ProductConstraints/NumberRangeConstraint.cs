using ProductManagement.Domain.Model.Constraints;

namespace ProductManagement.Domain.Model.Product.ProductConstraints
{
    public class NumberRangeConstraint : ProductConstraint
    {
        public decimal? Min { get; private set; }
        public decimal? Max { get; private set; }

        public NumberRangeConstraint(decimal? min, decimal? max, Constraint constraint) : base(constraint)
        {
            this.Max = max;
            this.Min = min;
        }
    }
}
