using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using Castle.Windsor;
using Framework.Config.Castle;
using ProductManagement.Config.Castle;
using ServiceHost.App_Start;
using UOM.Config.Castle;

namespace ServiceHost
{
    public static class HostConfigurator
    {
        public static void Config(HttpConfiguration configuration)
        {
            var container = new WindsorContainer();
            FrameworkBootstrapper.Config(container,"DBConnection");
            UomBootstrapper.Config(container);
            ProductBootstrapper.Config(container);

            var castleActivator = new CastleControllerActivator(container);
            configuration.Services.Replace(typeof(IHttpControllerActivator), castleActivator);
            configuration.Services.Replace(typeof(IHttpControllerSelector),new CqsControllerSelector(GlobalConfiguration.Configuration));
        }
    }
}