namespace ProductManagement.Application.Contracts
{
    public class NumericRangeConstraintDto : ProductConstraintDto
    {
        public long? Min { get; set; }
        public long? Max { get; set; }
    }
}