using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core.EventHandling;

namespace UOM.Domain.Contracts
{
    public class DimensionCreated : IEvent
    {
        public Guid EventId { get; private set; }
        public Guid Id  { get; private set; }
        public string Name  { get; private set; }
        public DimensionCreated(Guid id, string name)
        {
            Id = id;
            Name = name;
            this.EventId = Guid.NewGuid();
        }

    }
}
