namespace Framework.Domain.Specifications
{
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        private ISpecification<T> _firstSpec;
        private ISpecification<T> _secondSpec;
        public AndSpecification(ISpecification<T> firstSpec, ISpecification<T> secondSpec)
        {
            _firstSpec = firstSpec;
            _secondSpec = secondSpec;
        }

        public override bool IsSatisfiedBy(T entry)
        {
            return _firstSpec.IsSatisfiedBy(entry) && _secondSpec.IsSatisfiedBy(entry);
        }
    }
}