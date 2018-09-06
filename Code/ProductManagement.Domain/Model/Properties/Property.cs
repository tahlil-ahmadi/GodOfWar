using ProductManagement.Domain.Model.Constraints;

namespace ProductManagement.Domain.Model.Properties
{
    public class Property
    {
        public string Title { get; private set; }
        public Constraint Constraint { get; private set; }

        public Property(string title, Constraint constraint)
        {
            Title = title;
            Constraint = constraint;
        }
    }
}
