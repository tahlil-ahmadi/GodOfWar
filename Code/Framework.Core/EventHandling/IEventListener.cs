using System;

namespace Framework.Core.EventHandling
{
    public interface IEventListener
    {
        void Subscribe<T>(IEventHandler<T> handler) where T : IEvent;
        void Subscribe<T>(Action<T> action) where T : IEvent;
    }
}