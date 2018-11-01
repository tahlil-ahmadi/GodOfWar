using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ProductManagement.Domain.Model.Product.ProductConstraints;

namespace ProductManagement.Domain.Model.Product
{
    public class GenericProduct
    {
        private List<ProductConstraint> _constraints;
        public long Id { get; }
        public string Name { get; }
        public ReadOnlyCollection<ProductConstraint> Constraints => _constraints.AsReadOnly();

        public GenericProduct(long id, string name, List<ProductConstraint> constraints)
        {
            GuardAgainstDuplicateConstraint(constraints);

            this.Id = id;
            this.Name = name;
            this._constraints = constraints;
        }

        private static void GuardAgainstDuplicateConstraint(List<ProductConstraint> constraints)
        {
            var anyDuplicate = constraints.GroupBy(a => a.ConstraintId, (key, value) => new {key, value})
                .Any(a => a.value.Count() > 1);
            if (anyDuplicate)
                throw new DuplicateProductConstraintException();
        }
    }
}
