using System;

namespace Framework.Core.EventHandling
{
    public class BaseEvent : IEvent
    {
        public Guid EventId { get; protected set; }
       
    }
}