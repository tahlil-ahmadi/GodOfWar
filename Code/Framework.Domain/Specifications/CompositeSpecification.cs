namespace Framework.Domain.Specifications
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        public abstract bool IsSatisfiedBy(T entry);

        public CompositeSpecification<T> And(ISpecification<T> spec)
        {
            return new AndSpecification<T>(this, spec);
        }
        //public CompositeSpecification<T> Or(ISpecification<T> spec);
        //public CompositeSpecification<T> Not();
    }
}