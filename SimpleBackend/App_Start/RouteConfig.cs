using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleBackend
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Demo", action = "Login", id = UrlParameter.Optional }
            );
        }
    }
}
