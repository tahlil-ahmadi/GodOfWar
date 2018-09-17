using System;
using Framework.Domain;

namespace ProductManagement.Domain.Model.Properties
{
    public class Property : AggregateRoot<long>
    {
        public string Name { get; private set; }

        public Property(long id, string name)
        {
            Validate(name);
            Id = id;
            Name = name;
        }

        private void Validate(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Property Name could not be null or empty.");
        }
    }
}
