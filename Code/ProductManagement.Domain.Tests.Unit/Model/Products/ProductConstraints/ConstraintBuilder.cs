using ProductManagement.Domain.Model.Constraints;

namespace ProductManagement.Domain.Tests.Unit.Model.Products.ProductConstraints
{
    internal class ConstraintBuilder
    {
        private long _id;
        private string _title;

        public ConstraintBuilder()
        {
            _id = 0;
            _title = "";
        }
        public Constraint Build()
        {
            return new Constraint() { Id = _id, Title = _title };
        }

        public ConstraintBuilder WithTitle(string title)
        {
            _title = title;
            return this;
        }

        public ConstraintBuilder WithId(long id)
        {
            _id = id;
            return this;
        }
    }
}
