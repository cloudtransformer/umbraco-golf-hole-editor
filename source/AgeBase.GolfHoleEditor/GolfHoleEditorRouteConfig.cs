using System.Web.Mvc;
using System.Web.Routing;

namespace AgeBase.GolfHoleEditor
{
    public class GolfHoleEditorRouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(
                name: "GolfHoleEditor",
                url: "App_Plugins/AgeBase.GolfHoleEditor/{action}/{id}",
                defaults: new { controller = "GolfHoleEditor", action = "Resource", id = UrlParameter.Optional }
                );
        }
    }
}