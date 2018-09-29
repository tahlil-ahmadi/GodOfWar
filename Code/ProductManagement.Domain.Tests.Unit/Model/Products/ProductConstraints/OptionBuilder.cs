using System.Collections.Generic;
using System.Linq;
using ProductManagement.Domain.Model.Product.ProductConstraints;

namespace ProductManagement.Domain.Tests.Unit.Model.Products.ProductConstraints
{
    internal class OptionBuilder
    {
        private string _title;
        private long _value;

        public Option Build()
        {
            return new Option(_title, _value);
        }

        public List<Option> BuildListOptionsFrom(params Option[] options)
        {
            var listOptions = options.ToList();
            return listOptions;
        }

        public OptionBuilder WithTitle(string title)
        {
            this._title = title;
            return this;
        }

        public OptionBuilder WithValue(long value)
        {
            this._value = value;
            return this;
        }
    }
}
