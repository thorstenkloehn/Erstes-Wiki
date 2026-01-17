
using System.Numerics;


namespace Erstes_Wiki.Models;

public class Seite
{
    /// <summary>
    /// Eindeutige ID der Seite.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// slug oder URL der Seite.
    /// </summary>
    public string Slug { get; set; } = string.Empty;

    /// <summary>
    /// Inhalt der Seite im Markdown-Format.
    /// </summary>
    public string InputMarkdown { get; set; } = string.Empty;

    /// <summary>
    /// Gerenderter HTML-Inhalt der Seite.
    /// </summary>
    public string OutputHtml { get; set; } = string.Empty;

    /// <summary>
    /// Gibt an, ob die Seite veröffentlicht ist.
    /// </summary>
    public bool IstVeröffentlicht { get; set; }
}
