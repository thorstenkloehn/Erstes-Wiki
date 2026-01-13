using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Erstes_Wiki.Models;

namespace Erstes_Wiki.Controllers;

/// <summary>
/// Der HomeController steuert die Startseite und die Datenschutzseite.
/// </summary>
public class HomeController : Controller
{
    /// <summary>
    /// Zeigt die Startseite an.
    /// </summary>
    public IActionResult Index()
    {
        return View();
    }

    /// <summary>
    /// Zeigt die Datenschutzseite an.
    /// </summary>
    public IActionResult Privacy()
    {
        return View();
    }

    /// <summary>
    /// Zeigt die Fehlerseite an.
    /// </summary>
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
