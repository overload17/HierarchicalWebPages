using System.Web.Mvc;
using System.Web.Routing;

namespace HierarchicalWebApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",
                "{*path}",
                new {controller = "Home", action = "Folder"});
        }
    }
}
