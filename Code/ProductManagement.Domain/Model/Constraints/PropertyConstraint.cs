using ProductManagement.Domain.Model.Properties;

namespace ProductManagement.Domain.Model.Constraints
{
    public class PropertyConstraint
    {
        public long PropertyId { get; private set; }
        public Constraint Constraint { get; private set; }

        public PropertyConstraint(Property property, Constraint constraint)
        {
            PropertyId = property.Id;
            Constraint = constraint;
        }
    }
}