using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EmployeesAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Web API configuration and services
            //var cors = new EnableCorsAttribute(GetAllowedOrigins(), "*", "*");
            //config.EnableCors(cors);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // solution for error: Multiple actions were found that match the request in Web Api

           // config.Routes.MapHttpRoute(
           //    name: "DefaultApi",
           //    routeTemplate: "api/{controller}/{action}/{id}",
           //    defaults: new { id = RouteParameter.Optional }
           //);
        }

        private static string GetAllowedOrigins()
        {
            return "http://localhost:8080/";
        }
    }
}
