using System.Web.Mvc;

namespace ViewWithoutControllerDemo.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Get(string viewPath)
        {
            string controllerName = "Home";
            string actionName = "Index";
            if (!string.IsNullOrWhiteSpace(viewPath)) 
            {
                var extractedPath = viewPath.Split('/');
                controllerName = extractedPath[0];
                actionName = (extractedPath.Length > 1 && !string.IsNullOrWhiteSpace(extractedPath[1])) ? extractedPath[1] : "Index";
            }
            this.ControllerContext.RouteData.Values["controller"] = controllerName;
            this.ControllerContext.RouteData.Values["action"] = actionName;
            return View();
        }
    }
}