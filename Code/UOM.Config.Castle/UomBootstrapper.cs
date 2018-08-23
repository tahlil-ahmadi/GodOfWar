using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using UOM.Application;
using UOM.Domain.Model.Dimensions;
using UOM.Interface.RestApi;

namespace UOM.Config.Castle
{
    public static class UomBootstrapper
    {
        public static void Config(IWindsorContainer container)
        {
            container.Register(Component.For<IDimensionService>()
                .ImplementedBy<DimensionService>());

            container.Register(Component.For<IDimensionRepository>()
                .ImplementedBy<FakeDimensionRepository>());

            container.Register(Component.For<DimensionsController>()
                .LifestyleTransient());
        }
    }
}
