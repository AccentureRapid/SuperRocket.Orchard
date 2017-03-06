using System.Web.Mvc;

namespace SuperRocket.Orchard.Web.Controllers
{
    public class AboutController : OrchardControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}