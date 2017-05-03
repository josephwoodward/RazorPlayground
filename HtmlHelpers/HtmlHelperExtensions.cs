using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorDeepDive.HtmlHelpers
{
    public static class HtmlHelperExtensions
    {
        public static HtmlPanelComponent AcmePanel(this IHtmlHelper html, string panelTitle)
        {
            html.ViewContext.Writer.Write(
                "<div class=\"panel\">" +
                "<div class=\"panel-inner\">" +
                "<h2 class=\"panel-title\">" + panelTitle + "</h2>" +
                "<div class=\"panel-content\">"
            );

            return new HtmlPanelComponent(html.ViewContext);
        }
    }

    public class HtmlPanelComponent : IDisposable
    {
        private readonly ViewContext _viewContext;

        public HtmlPanelComponent(ViewContext viewContext)
        {
            _viewContext = viewContext;
        }

        public void Dispose()
        {
            _viewContext.Writer.Write(
                "</div>" +
                "</div>" +
                "</div>"
            );
        }
    }
}