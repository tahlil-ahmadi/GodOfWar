using System;
using Framework.Domain.Specifications.Common;
using ProductManagement.Domain.Model.Constraints;

namespace ProductManagement.Domain.Model.Product.ProductConstraints
{
    public class NumberRangeConstraint : ProductConstraint
    {
        public decimal? Min { get; private set; }
        public decimal? Max { get; private set; }

        public NumberRangeConstraint(long constraintId, decimal? min, decimal? max) : base(constraintId)
        {
            if (max < min) throw new ArgumentException("Max is smaller than min", nameof(max));

            this.Max = max;
            this.Min = min;
        }

        public bool Validate(int characteristicValue)
        {
            var max = this.Max ?? decimal.MaxValue;
            var min = this.Min ?? decimal.MinValue;

            return new MaxSpecification<decimal>(max)
                            .And(new MinSpecification<decimal>(min))
                            .IsSatisfiedBy(characteristicValue);
        }
    }
}
