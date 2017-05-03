using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace RazorDeepDive.TagHelpers
{
    [HtmlTargetElement("p")]
    public class HeadTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var content = output.Content.GetContent();
            var res = output.GetChildContentAsync().Result;


            Debug.WriteLine(content);

            base.Process(context, output);
        }
    }
}