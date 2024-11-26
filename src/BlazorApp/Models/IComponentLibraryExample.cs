using BlazorApp.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Models;

public interface IComponentLibraryExample
{
    static abstract Task<List<HtmlExample>> GetHtmlExamplesAsync(ComponentRenderingService componentRenderingService);
}
