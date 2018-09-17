using ProductManagement.Domain.Model.Properties;

namespace ProductManagement.Domain.Tests.Unit.PropertyTests
{
    internal class PropertyBuilder
    {
        private string _name;
        private long _id;

        public PropertyBuilder()
        {
            _id = 0;
            _name = "";
        }

        public Property Build()
        {
            return new Property(_id,_name);
        }

        public PropertyBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public PropertyBuilder WithId(long id)
        {
            _id = id;
            return this;
        }
    }
}