using Framework.Domain;

namespace ProductManagement.Domain.Model.Properties
{
    public class Property : AggregateRoot<long>
    {
        public string Name { get; private set; }

        public Property(string name)
        {
            Name = name;
        }
    }
}
