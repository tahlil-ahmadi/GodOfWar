using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagement.Domain.Model.Constraints;

namespace ProductManagement.Domain.Model.Product.ProductConstraints
{
    public abstract class ProductConstraint
    {
        public long ConstraintId { get; set; }
        protected ProductConstraint(long constraintId)
        {
            this.ConstraintId = constraintId;
        }
    }
}
