using System.Collections.Generic;
using Framework.Core.EventHandling;

namespace Framework.Domain
{
    public class AggregateRoot<TKey> : Entity<TKey>
    {
        private readonly IEventPublisher _publisher;
        private readonly List<IEvent> _changes = new List<IEvent>();
        public AggregateRoot()
        {
        }
        public AggregateRoot(IEventPublisher publisher)
        {
            this._publisher = publisher;
        }

        public void Publish<T>(T @event) where  T : IEvent
        {
            this._changes.Add(@event);
            this._publisher.Publish(@event);
        }
    }
}
