using System;
using System.Collections.Generic;
using Framework.Core.EventHandling;
using Framework.Domain;
using UOM.Domain.Contracts;

namespace UOM.Domain.Model.Dimensions
{
    public class Dimension : AggregateRoot<Guid>
    {
        public string Name { get; private set; }
        protected Dimension(){} //For ORM Only
        public Dimension(string name, IEventPublisher publisher) : base(publisher)
        {
            this.Id = Guid.NewGuid();
            Name = name;
            Publish(new DimensionCreated(this.Id, this.Name));
        }
    }
}
