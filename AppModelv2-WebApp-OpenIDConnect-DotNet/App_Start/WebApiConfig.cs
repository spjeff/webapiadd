using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AppModelv2_WebApp_OpenIDConnect_DotNet
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Enable CORS
            config.EnableCors();

            //REM config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
