using ProductManagement.Domain.Model.Constraints;

namespace ProductManagement.Domain.Model.Product.ProductConstraints
{
    public class StringConstraint : ProductConstraint
    {
        public long MaxLength { get;private set; }
        public string Format { get;private set; }

        public StringConstraint(long constraintId, long maxLength) : base(constraintId)
        {
            this.MaxLength = maxLength;
        }
    }
}