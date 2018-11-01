namespace ProductManagement.Domain.Model.Constraints
{
    public class Constraint
    {
        public long Id { get; private set; }
        public string Title { get; private set; }

        public Constraint(long id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
