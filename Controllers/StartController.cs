using Microsoft.AspNetCore.Mvc;

namespace Erstes_Wiki.Controllers
{
    /// <summary>
    /// Der PageController steuert die Neben Seite.
    /// </summary>
    public class StartController : Controller
    {
        // GET: StartController
        public ActionResult Index()
        {
            return View();
        }
    }
}
