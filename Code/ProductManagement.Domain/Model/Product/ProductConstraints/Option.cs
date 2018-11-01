namespace ProductManagement.Domain.Model.Product.ProductConstraints
{
    public class Option
    {
        public string Value { get; set; }
        public long Key { get; set; }
        public Option(string value, long key)
        {
            Value = value;
            Key = key;
        }
    }
}