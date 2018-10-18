using System.Web.Http;
using System.Web.Http.Dispatcher;
using Castle.Windsor;
using Framework.Config.Castle;
using ServiceHost.App_Start;
using UOM.Config.Castle;

namespace ServiceHost
{
    public static class HostConfigurator
    {
        public static void Config()
        {
            var container = new WindsorContainer();
            UomBootstrapper.Config(container);
            FrameworkBootstrapper.Config(container,"DBConnection");

            var castleActivator = new CastleControllerActivator(container);
            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator), castleActivator);
            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerSelector), 
                new CqsControllerSelector(GlobalConfiguration.Configuration));
        }
    }
}