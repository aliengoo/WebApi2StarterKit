namespace WebApi2Starter
{
    using System.Web.Http;

    using Owin;

    public static class StartUpRouting
    {
         public static void SetRoutes(this HttpConfiguration configuration)
         {
             // Enable attribute routing
             configuration.MapHttpAttributeRoutes();

             // Enable default HTTP routing
             configuration.Routes.MapHttpRoute(
                 name: "DefaultApi",
                 routeTemplate: "api/{controller}/{id}",
                 defaults: new { id = RouteParameter.Optional });

             configuration.Routes.MapHttpRoute(
                 name: "DefaultApiWithAction",
                 routeTemplate: "api/{controller}/{action}/{id}",
                 defaults: new { id = RouteParameter.Optional });

         }
    }
}