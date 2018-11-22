using System;
using System.Threading.Tasks;
using System.Web.Http;
using IdentityServer3.AccessTokenValidation;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ServiceHost.App_Start.Startup))]
namespace ServiceHost.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            SetupAccessTokenValidation(app);
            WebApiConfig.Register(config);
            HostConfigurator.Config(config);
            app.UseWebApi(config);
        }

        private static void SetupAccessTokenValidation(IAppBuilder app)
        {
            app.UseIdentityServerBearerTokenAuthentication(new IdentityServerBearerTokenAuthenticationOptions
            {
                Authority = "http://localhost:5000"
            });
        }
    }
}
