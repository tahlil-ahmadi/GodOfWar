namespace Framework.Core.EventHandling
{
    public interface IEventAggregator
    {
        void Publish<T>(T @event) where T : IEvent;
        void Subscribe<T>(IEventHandler<T> handler) where T : IEvent;
    }
}