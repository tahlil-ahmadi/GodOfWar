namespace ProductManagement.Domain.Model.Constraints
{
    public class Numeric<T> : Constraint
    {
        public T FromNumeric { get; private set; }
        public T ToNumeric { get; private set; }

        public Numeric(T fromNumeric, T toNumeric)
        {
            FromNumeric = fromNumeric;
            ToNumeric = toNumeric;
        }
    }
}
