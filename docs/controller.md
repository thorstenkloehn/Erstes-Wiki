# HomeController

Der HomeController ist für die Startseite und die Datenschutzseite zuständig.

## Aktionen

- **Index**: Zeigt die Startseite an.
- **Privacy**: Zeigt die Datenschutzseite an.

## Beispiel-Code

```csharp
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
```
