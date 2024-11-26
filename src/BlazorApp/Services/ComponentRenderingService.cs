using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorApp.Services;

public class ComponentRenderingService(ILoggerFactory loggerFactory, IHttpContextAccessor httpContextAccessor)
{
    ////public async Task<string> GetAlertAsHtmlAsync(Models.Alert alert)
    ////{
    ////    var alertDictionary = new Dictionary<string, object?>
    ////    {
    ////        { "AlertModel", alert },
    ////    };
    ////    var alertHtml = await this.GetAsHtmlAsync<AlertComponent>(alertDictionary);
    ////    return alertHtml;
    ////}

    public async Task<string> GetAsHtmlAsync<T>(Dictionary<string, object?> dictionary)
        where T : IComponent
    {
        var parameters = ParameterView.FromDictionary(dictionary);

        await using var htmlRenderer = new HtmlRenderer(httpContextAccessor.HttpContext!.RequestServices, loggerFactory);
        var html = await htmlRenderer.Dispatcher.InvokeAsync(async () =>
        {
            var output = await htmlRenderer.RenderComponentAsync<T>(parameters);
            return output.ToHtmlString();
        });
        return html;
    }
}
