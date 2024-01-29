using BlazorAppSsrWasm.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorAppSsrWasm.Models;

public interface IComponentLibraryExample
{
    static abstract Task<List<HtmlExample>> GetHtmlExamplesAsync(ComponentRenderingService componentRenderingService);
}
