using System.Web.Routing;
using Umbraco.Core;

namespace AgeBase.GolfHoleEditor
{
    public class GolfHoleEditorStartupHandler : ApplicationEventHandler
    {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            GolfHoleEditorRouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}