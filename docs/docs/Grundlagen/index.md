# Entwickeln Asp Net Core MVC

## Grundlagen in C#

Um C# zu beherrschen, sollte man die folgenden Konzepte kennen:

- Variablen und Datentypen
- Kontrollstrukturen (if, switch, Schleifen)
- Methoden und Parameter
- Klassen und Objekte
- Vererbung und Polymorphismus
- Schnittstellen
- Fehlerbehandlung (Exceptions)
- Collections und LINQ
- Asynchrone Programmierung

## HTTP Grundlagen in C#

Um mit HTTP in C# zu arbeiten, verwendet man häufig die Klasse `HttpClient` aus dem Namespace `System.Net.Http`. Damit können HTTP-Anfragen gesendet und Antworten empfangen werden.

## Routing in ASP.NET Core

In ASP.NET Core werden Seiten und Controller über Routing angesprochen. Das Routing bestimmt, welche URL auf welche Seite oder Aktion verweist.

### Seiten Router
```csharp
// Mit dieser Route werden alle Anfragen, die keinem anderen Muster entsprechen,
// an den "Seite"-Controller und die "Index"-Aktion weitergeleitet.
// Das Muster "{*slug}" fängt beliebige Pfade ab (z. B. /info/test/seite).
// "WithStaticAssets()" sorgt dafür, dass statische Dateien wie Bilder oder CSS weiterhin erreichbar sind.
app.MapControllerRoute(
    name: "cms",
    pattern: "{*slug}",
    defaults: new { controller = "Seite", action = "Index" })
    .WithStaticAssets();
```








