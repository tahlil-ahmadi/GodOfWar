using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace ServiceHost.App_Start
{
    public class CqsControllerSelector : DefaultHttpControllerSelector
    {
        public CqsControllerSelector(HttpConfiguration configuration) : base(configuration)
        {
        }

        public override string GetControllerName(HttpRequestMessage request)
        {
            var controllerName = base.GetControllerName(request);
            if (request.Method == HttpMethod.Get)
            {
                controllerName = controllerName + "Query";
            }
            return controllerName;
        }
    }
}