using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Framework.Application;
using Framework.CastleWindsor;
using Framework.Core;
using Framework.Core.EventHandling;

namespace Framework.Config.Castle
{
    public static class FrameworkBootstrapper
    {
        public static void Config(IWindsorContainer container)
        {
            container.Register(Component.For<IServiceLocator>()
                .Instance(new WindsorServiceLocator(container))
                .LifestyleSingleton());

            container.Register(Component.For<ICommandBus>()
                .ImplementedBy<CommandBus>()
                .LifestyleSingleton());

            container.Register(Component.For<IEventPublisher>()
                .Forward<IEventListener>()
                .ImplementedBy<EventAggregator>()
                .LifestylePerWebRequest());
        }
    }
}
