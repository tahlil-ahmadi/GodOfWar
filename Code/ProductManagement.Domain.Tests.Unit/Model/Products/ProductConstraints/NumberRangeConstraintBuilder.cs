using ProductManagement.Domain.Model.Constraints;
using ProductManagement.Domain.Model.Product.ProductConstraints;

namespace ProductManagement.Domain.Tests.Unit.Model.Products.ProductConstraints
{
    internal class NumberRangeConstraintBuilder
    {
        private decimal? min;
        private decimal? max;
        private Constraint _constraint;


        public NumberRangeConstraint Build()
        {
            return new NumberRangeConstraint(min, max, _constraint);
        }

        public NumberRangeConstraintBuilder WithMin(decimal? min)
        {
            this.min = min;
            return this;
        }

        public NumberRangeConstraintBuilder WithMax(decimal? max)
        {
            this.max = max;
            return this;
        }

        public NumberRangeConstraintBuilder WithConstraint(Constraint constraint)
        {
            this._constraint = constraint;
            return this;
        }
    }
}
