using System;
using ProductManagement.Domain.Model.Constraints;

namespace ProductManagement.Domain.Model.Product.ProductConstraints
{
    public class StringConstraint : ProductConstraint
    {
        public long MaxLength { get;private set; }
        public string Format { get;private set; }

        public StringConstraint(string format, long maxLength,Constraint constraint) : base(constraint)
        {
            GuardAgaintsMaxLengthLowerThan(maxLength);

            this.Format = format;
            this.MaxLength = maxLength;
        }

        private static void GuardAgaintsMaxLengthLowerThan(long zero)
        {
            if (zero < 1) throw new MaxLengthException();
        }
    }
}