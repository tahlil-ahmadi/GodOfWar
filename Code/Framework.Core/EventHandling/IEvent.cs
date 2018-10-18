using System;

namespace Framework.Core.EventHandling
{
    public interface IEvent
    {
        Guid EventId { get; }
    }
}
