using System;
using System.Collections.Generic;
using System.Linq;

namespace Framework.Core.EventHandling
{
    public class EventAggregator : IEventListener, IEventPublisher
    {
        private readonly List<object> _subscribers = new List<object>();
        public void Publish<T>(T @event) where T : IEvent
        {
            var targetHandlers = _subscribers.OfType<IEventHandler<T>>().ToList();
            targetHandlers.ForEach(handler =>
            {
                handler.Handle(@event);
            });
        }

        public void Subscribe<T>(IEventHandler<T> handler) where T : IEvent
        {
            _subscribers.Add(handler);
        }

        public void Subscribe<T>(Action<T> action) where T : IEvent
        {
            Subscribe(new ActionHandler<T>(action));
        }
    }
}