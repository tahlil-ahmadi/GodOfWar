using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Framework.Application;
using Framework.NH;
using NHibernate;
using UOM.Application;
using UOM.Domain.Model.Dimensions;
using UOM.Interface.RestApi;
using UOM.Persistence.NH.Mappings;
using UOM.Persistence.NH.Repositories;

namespace UOM.Config.Castle
{
    public static class UomBootstrapper
    {
        public static void Config(IWindsorContainer container)
        {
            container.Register(Classes.FromAssemblyContaining<DimensionCommandHandlers>()
                .BasedOn(typeof(ICommandHandler<>))
                .WithServiceAllInterfaces()
                .LifestyleTransient());

            container.Register(Component.For<DimensionsController>()
                .LifestyleTransient());

            ConfigPersistence(container);
        }

        private static void ConfigPersistence(IWindsorContainer container)
        {
            var sessionFactory = SessionFactoryConfigurator.Create("DBConnection", typeof(DimensionMapping).Assembly);

            container.Register(Component.For<ISession>()
                .UsingFactoryMethod(a => sessionFactory.OpenSession())
                .LifestylePerWebRequest());

            container.Register(Component.For<IDimensionRepository>()
                .ImplementedBy<DimensionRepository>()
                .LifestylePerWebRequest());
        }
    }
}
