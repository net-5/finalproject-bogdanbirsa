using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("editions")]
    public class EditionTagHelper : TagHelper
    {
        private readonly IEditionsService editionServices;
        private const string ForAttributeName = "asp-for";
        public EditionTagHelper(IEditionsService editionServices)
        {
            this.editionServices = editionServices;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var allEditions = editionServices.GetAllEditions();
            output.TagName = "select";
            output.Attributes.Add("class", "form-control");
            foreach (var edition in allEditions)
            {
                TagBuilder myOption = new TagBuilder("option")
                {
                    TagRenderMode = TagRenderMode.Normal
                };
                myOption.Attributes.Add("value", edition.Name);
                myOption.InnerHtml.Append(edition.Name);
                output.Content.AppendHtml(myOption);
            }
        }
    }
}
