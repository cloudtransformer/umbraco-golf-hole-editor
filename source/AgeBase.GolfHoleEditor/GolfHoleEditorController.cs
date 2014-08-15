using System.Linq;
using System.Reflection;
using System.Web.Mvc;

namespace AgeBase.GolfHoleEditor
{
    public class GolfHoleEditorController : Controller
    {
        public FileStreamResult Resource(string id)
        {
            var resourceName = Assembly.GetExecutingAssembly().GetManifestResourceNames().ToList().FirstOrDefault(f => f.EndsWith(id));
            var a = typeof(GolfHoleEditorController).Assembly;

            return new FileStreamResult(a.GetManifestResourceStream(resourceName), GetMimeType(id));
        }

        private static string GetMimeType(string fileId)
        {
            if (fileId.EndsWith(".js"))
                return "text/javascript";

            if (fileId.EndsWith(".html"))
                return "text/html";

            return fileId.EndsWith(".css") ? "text/css" : "text";
        }
    }
}