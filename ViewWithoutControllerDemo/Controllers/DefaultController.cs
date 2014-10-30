using System.Web.Mvc;

namespace ViewWithoutControllerDemo.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Get(string viewPath)
        {
            var extractedPath = viewPath.Split('/');
            this.ControllerContext.RouteData.Values["controller"] = extractedPath[0];
            this.ControllerContext.RouteData.Values["action"] = extractedPath[1];
            return View();
        }
    }
}