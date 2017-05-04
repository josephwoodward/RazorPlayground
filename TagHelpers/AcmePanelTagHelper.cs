using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using RazorDeepDive.Services;

namespace RazorDeepDive.TagHelpers
{
    public class AcmePanelTagHelper : TagHelper
    {
        public string Title { get; set; }
        private readonly IUserConfiguration _configuration;

        public AcmePanelTagHelper(IUserConfiguration configuration)
        {
            _configuration = configuration;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var content = await output.GetChildContentAsync();

            string panel = $@"
            <div class=""panel"">
                <div class=""panel-inner"">
                    <h2 class=""panel-title"">{Title} {_configuration.Name}</h2>
                    <div class=""panel-content"">{content.GetContent()}</div>
                </div>
            </div>";

            output.Content.SetHtmlContent(panel);
        }
    }
}