using System.Web.Mvc;
using System.Web.Routing;

namespace ViewWithoutControllerDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{*viewPath}",
                defaults: new { controller = "Default", action = "Get", id = UrlParameter.Optional }
            );
        }
    }
}