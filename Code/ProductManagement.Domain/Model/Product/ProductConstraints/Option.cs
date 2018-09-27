namespace ProductManagement.Domain.Model.Product.ProductConstraints
{
    public class Option
    {
        public string Title { get; set; }
        public long Value { get; set; }
        public Option(string title, long value)
        {
            Title = title;
            Value = value;
        }
    }
}