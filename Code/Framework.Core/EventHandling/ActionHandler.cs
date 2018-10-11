using System;

namespace Framework.Core.EventHandling
{
    public class ActionHandler<T> : IEventHandler<T> where T : IEvent
    {
        private Action<T> _action;
        public ActionHandler(Action<T> action)
        {
            _action = action;
        }

        public void Handle(T @event)
        {
            _action(@event);
        }
    }
}
