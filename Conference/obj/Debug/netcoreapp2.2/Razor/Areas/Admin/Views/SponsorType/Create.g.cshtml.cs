#pragma checksum "D:\De la ore\Conference\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\SponsorType\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b7b314e50afc1eb7e6b084abfb4600ab8d1ee71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SponsorType_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/SponsorType/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/SponsorType/Create.cshtml", typeof(AspNetCore.Areas_Admin_Views_SponsorType_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b7b314e50afc1eb7e6b084abfb4600ab8d1ee71", @"/Areas/Admin/Views/SponsorType/Create.cshtml")]
    public class Areas_Admin_Views_SponsorType_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Conference.Areas.Admin.Models.SponsorTypeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\De la ore\Conference\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\SponsorType\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(103, 1539, true);
            WriteLiteral(@"
<h1>Create</h1>

<h4>SponsorTypeViewModel</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Id"" class=""control-label""></label>
                <input asp-for=""Id"" class=""form-control"" />
                <span asp-validation-for=""Id"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Order"" class=""control-label""></label>
                <input asp-for=""Order"" class=""form-control"" />
                <span asp-validation-for=""Order"" class=""text-danger""></span>
            </div>
");
            WriteLiteral(@"            <div class=""form-group"">
                <label asp-for=""Edition"" class=""control-label""></label>
                <input asp-for=""Edition"" class=""form-control"" />
                <span asp-validation-for=""Edition"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1660, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 47 "D:\De la ore\Conference\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\SponsorType\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Conference.Areas.Admin.Models.SponsorTypeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
