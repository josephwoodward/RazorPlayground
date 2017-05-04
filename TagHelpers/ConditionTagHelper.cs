using Microsoft.AspNetCore.Razor.TagHelpers;

namespace RazorDeepDive.TagHelpers
{
    // Target any HTML element with condition attribute
    [HtmlTargetElement(Attributes = nameof(Condition))]
    public class ConditionTagHelper : TagHelper
    {
        public bool Condition { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!Condition)
            {
                output.SuppressOutput();
            }
        }
    }
}