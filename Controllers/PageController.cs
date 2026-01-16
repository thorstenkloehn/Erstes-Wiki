using Microsoft.AspNetCore.Mvc;

/// <summary>
/// Enthält Controller für Wiki-Seiten.
/// </summary>
namespace Erstes_Wiki.Controllers
{
 /// <summary>
/// Der PageController steuert die Startseite .
/// </summary>
    public class PageController : Controller
    {
     
     /// <summary>
     /// GET: PageController
     /// </summary>
     /// <param name="slug"></param>
     /// <returns></returns>
        public ActionResult Index(string slug)
        {

            return View();
        }
    }
}