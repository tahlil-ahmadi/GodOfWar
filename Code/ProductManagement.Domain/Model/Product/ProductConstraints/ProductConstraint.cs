using ProductManagement.Domain.Model.Constraints;

namespace ProductManagement.Domain.Model.Product.ProductConstraints
{
    public abstract class ProductConstraint
    {
        public long ConstraintId { get; set; }
        protected ProductConstraint(Constraint constraint)
        {
            this.ConstraintId = constraint.Id;
        }
    }
}
