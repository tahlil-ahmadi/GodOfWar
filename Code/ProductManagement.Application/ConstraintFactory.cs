using System;
using System.Collections.Generic;
using ProductManagement.Application.Contracts;
using ProductManagement.Domain.Model.Product.ProductConstraints;

namespace ProductManagement.Application
{
    public class ConstraintFactory
    {
        public static List<ProductConstraint> CreateFromDto(List<ProductConstraintDto> commandConstraints)
        {
            var constraints = new List<ProductConstraint>();
            foreach (var dto in commandConstraints)
            {
                constraints.Add(Map((dynamic)dto));
            }
            return constraints;
        }

        public static NumberRangeConstraint Map(NumericRangeConstraintDto dto)
        {
            return new NumberRangeConstraint(dto.ConstraintId, dto.Min, dto.Max);
        }
        public static StringConstraint Map(StringProductConstraintDto dto)
        {
            return new StringConstraint(dto.ConstraintId, dto.MaxLength);
        }
    }
}