using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("speakers")]
    public class SpeakersTagHelper : TagHelper
    {
        private readonly ISpeakerService speakersServices;
        public SpeakersTagHelper(ISpeakerService speakersServices)
        {
            this.speakersServices = speakersServices;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var allSpeakers = speakersServices.GetAllSpeakers();
            output.TagName = "select";
            output.Attributes.Add("class", "form-control");
            foreach (var speaker in allSpeakers)
            {
                TagBuilder myOption = new TagBuilder("option")
                {
                    TagRenderMode = TagRenderMode.Normal
                };
                myOption.Attributes.Add("value", speaker.FullName);
                myOption.InnerHtml.Append(speaker.FullName);
                output.Content.AppendHtml(myOption);
            }
        }
    }
}
