using System;

namespace Framework.Domain.Specifications.Common
{
    public class MinSpecification<T> : CompositeSpecification<T> where T : IComparable
    {
        private readonly T minValue;
        public MinSpecification(T minValue)
        {
            this.minValue = minValue;
        }
        public override bool IsSatisfiedBy(T entry)
        {
            var result = minValue.CompareTo(entry);
            return result <= 0;
        }
    }
}