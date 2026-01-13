using Microsoft.AspNetCore.Mvc;

namespace Erstes_Wiki.Controllers
{
 /// <summary>
/// Der PageController steuert die Startseite .
/// </summary>
    public class PageController : Controller
    {
     
        public ActionResult Index(string slug)
        {
            return View();
        }
    }
}