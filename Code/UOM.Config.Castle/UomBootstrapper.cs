using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Framework.Application;
using Framework.Core;
using Framework.NH;
using NHibernate;
using UOM.Application;
using UOM.Domain.Model.Dimensions;
using UOM.Interface.Facade;
using UOM.Interface.RestApi;
using UOM.Persistence.NH.Mappings;
using UOM.Persistence.NH.Repositories;
using UOM.Query.Model.Repositories;

namespace UOM.Config.Castle
{
    public static class UomBootstrapper
    {
        public static void Config(IWindsorContainer container)
        {
            container.Register(Component.For<PermissionInterceptor>().LifestyleBoundToNearest<IGateway>());

            container.Register(Classes.FromAssemblyContaining<DimensionCommandHandlers>()
                .BasedOn(typeof(ICommandHandler<>))
                .WithServiceAllInterfaces()
                .LifestyleTransient());

            container.Register(Classes.FromAssemblyContaining<DimensionFacade>()
                .BasedOn<IFacadeService>()
                .WithServiceFromInterface()
                .LifestyleBoundToNearest<IGateway>()
                .Configure(a=> a.Interceptors<PermissionInterceptor>()));

            container.Register(Classes.FromAssemblyContaining<DimensionsController>()
                .BasedOn<IGateway>()
                .LifestyleTransient());

            container.Register(Component.For<IDimensionQueryRepository>()
                .ImplementedBy<DimensionQueryRepository>()
                .LifestylePerWebRequest());

            ConfigPersistence(container);
        }

        private static void ConfigPersistence(IWindsorContainer container)
        {
            var sessionFactory = SessionFactoryConfigurator.Create("DBConnection", typeof(DimensionMapping).Assembly);

            container.Register(Component.For<ISession>()
                .UsingFactoryMethod(a =>
                {
                    var connection = a.Resolve<DbConnection>();
                    return sessionFactory
                        .WithOptions()
                        .Connection(connection)
                        .OpenSession();
                })
                .LifestylePerWebRequest());

            container.Register(Component.For<IDimensionRepository>()
                .ImplementedBy<DimensionRepository>()
                .LifestylePerWebRequest());
        }
    }
}
