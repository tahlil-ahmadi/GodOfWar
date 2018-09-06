using System;
using Framework.Domain;

namespace UOM.Domain.Model.Dimensions
{
    public class Dimension : AggregateRoot<Guid>
    {
        public string Name { get; private set; }
        protected Dimension(){} //For ORM Only
        public Dimension(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
