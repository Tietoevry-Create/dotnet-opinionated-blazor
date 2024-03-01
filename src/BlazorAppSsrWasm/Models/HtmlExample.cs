namespace BlazorAppSsrWasm.Models;

public class HtmlExample
{
    public HtmlExample(Type type)
    {
        this.TypeFullName = type?.FullName ?? string.Empty;
    }

    public string Variation { get; set; } = "Default";

    public string Name { get; set; } = string.Empty;

    public string ParentName { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Html { get; set; } = string.Empty;

    public string TypeFullName { get; private set; }
}
