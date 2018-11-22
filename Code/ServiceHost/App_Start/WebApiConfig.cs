using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ServiceHost
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var corsAttribute = new EnableCorsAttribute("http://localhost:7000","*","*");
            config.EnableCors(corsAttribute);

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
