#pragma checksum "D:\De la ore\Conference\Conference\Conference\Areas\Admin\Views\Speaker\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "523d4d4498ef063c41a3f7783197a1990e061602"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Speaker_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Speaker/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Speaker/Delete.cshtml", typeof(AspNetCore.Areas_Admin_Views_Speaker_Delete))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"523d4d4498ef063c41a3f7783197a1990e061602", @"/Areas/Admin/Views/Speaker/Delete.cshtml")]
    public class Areas_Admin_Views_Speaker_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Conference.Areas.Admin.Models.SpeakerViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\De la ore\Conference\Conference\Conference\Areas\Admin\Views\Speaker\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(99, 186, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>SpeakerViewModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(286, 38, false);
#line 15 "D:\De la ore\Conference\Conference\Conference\Areas\Admin\Views\Speaker\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(324, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(388, 34, false);
#line 18 "D:\De la ore\Conference\Conference\Conference\Areas\Admin\Views\Speaker\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(422, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(485, 40, false);
#line 21 "D:\De la ore\Conference\Conference\Conference\Areas\Admin\Views\Speaker\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(525, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(589, 36, false);
#line 24 "D:\De la ore\Conference\Conference\Conference\Areas\Admin\Views\Speaker\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(625, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(688, 43, false);
#line 27 "D:\De la ore\Conference\Conference\Conference\Areas\Admin\Views\Speaker\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TagLine));

#line default
#line hidden
            EndContext();
            BeginContext(731, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(795, 39, false);
#line 30 "D:\De la ore\Conference\Conference\Conference\Areas\Admin\Views\Speaker\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TagLine));

#line default
#line hidden
            EndContext();
            BeginContext(834, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(897, 40, false);
#line 33 "D:\De la ore\Conference\Conference\Conference\Areas\Admin\Views\Speaker\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(937, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1001, 36, false);
#line 36 "D:\De la ore\Conference\Conference\Conference\Areas\Admin\Views\Speaker\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(1037, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1100, 42, false);
#line 39 "D:\De la ore\Conference\Conference\Conference\Areas\Admin\Views\Speaker\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
            EndContext();
            BeginContext(1142, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1206, 38, false);
#line 42 "D:\De la ore\Conference\Conference\Conference\Areas\Admin\Views\Speaker\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Active));

#line default
#line hidden
            EndContext();
            BeginContext(1244, 208, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    <form asp-action=\"Delete\">\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        <a asp-action=\"Index\">Back to List</a>\r\n    </form>\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Conference.Areas.Admin.Models.SpeakerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
