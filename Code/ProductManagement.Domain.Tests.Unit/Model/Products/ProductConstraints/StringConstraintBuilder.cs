using ProductManagement.Domain.Model.Constraints;
using ProductManagement.Domain.Model.Product.ProductConstraints;

namespace ProductManagement.Domain.Tests.Unit.Model.Products.ProductConstraints
{
    internal class StringConstraintBuilder
    {
        private long maxlen;
        private string format;
        private Constraint _constraint;

        public StringConstraint Build()
        {
            return new StringConstraint(format, maxlen, _constraint);
        }

        public StringConstraintBuilder WithFormat(string format)
        {
            this.format = format;
            return this;
        }

        public StringConstraintBuilder WithMaxLength(long maxlen)
        {
            this.maxlen = maxlen;
            return this;
        }

        public StringConstraintBuilder WithConstraint(Constraint constraint)
        {
            this._constraint = constraint;
            return this;
        }
    }
}
