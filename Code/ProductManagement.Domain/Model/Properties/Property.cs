using System;
using Framework.Domain;

namespace ProductManagement.Domain.Model.Properties
{
    public class Property : AggregateRoot<long>
    {
        public string Name { get; private set; }

        public Property(string name)
        {
            Validate(name);
            Name = name;
        }

        public void Validate(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Property Name could not be null or empty.");
        }
    }
}
