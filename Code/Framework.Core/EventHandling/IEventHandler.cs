namespace Framework.Core.EventHandling
{
    public interface IEventHandler<in T> where T : IEvent
    {
        void Handle(T @event);
    }
}