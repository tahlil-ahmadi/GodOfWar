using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Framework.Application;
using Framework.Core;
using ProductManagement.Application;
using ProductManagement.Interface.RestApi;

namespace ProductManagement.Config.Castle
{
    public static class ProductBootstrapper
    {
        public static void Config(IWindsorContainer container)
        {
            container.Register(Classes.FromAssemblyContaining<GenericProductCommandHandlers>()
                .BasedOn(typeof(ICommandHandler<>))
                .WithServiceAllInterfaces()
                .LifestyleTransient());

            container.Register(Classes.FromAssemblyContaining<GenericProductsController>()
                .BasedOn<IGateway>()
                .LifestyleTransient());
        }
    }
}
