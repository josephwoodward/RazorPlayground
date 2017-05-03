using Microsoft.AspNetCore.Razor.TagHelpers;

namespace RazorDeepDive.TagHelpers
{
    [HtmlTargetElement("a", Attributes = "href")]
    public class NoFollowTagHelper : TagHelper
    {
        public string Href { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.TagMode = TagMode.StartTagAndEndTag;

            /*var res = output.Content.GetContent();*/
            output.Content.SetContent(nameof(NoFollowTagHelper));

            output.Attributes.SetAttribute("href", Href);

            if (!output.Attributes["href"].Value.ToString().Contains("josephwoodward.co.uk"))
            {
                output.Attributes.SetAttribute("rel", "nofollow");
            }

            base.Process(context, output);
        }
    }
}