#pragma checksum "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\Workshop\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32fe53b09b5a409fe20ae3446100410b35f23d5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Workshop_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Workshop/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Workshop/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Workshop_Details))]
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
#line 1 "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\_ViewImports.cshtml"
using Conference;

#line default
#line hidden
#line 2 "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\_ViewImports.cshtml"
using Conference.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32fe53b09b5a409fe20ae3446100410b35f23d5a", @"/Areas/Admin/Views/Workshop/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00c75cd38ac9654da86fbc3ee7161d0ab74e9c2b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Workshop_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Conference.Areas.Admin.Models.WorkshopViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\Workshop\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(101, 132, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Workshops</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(234, 38, false);
#line 14 "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\Workshop\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(272, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(336, 34, false);
#line 17 "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\Workshop\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(370, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(433, 40, false);
#line 20 "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\Workshop\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(473, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(537, 36, false);
#line 23 "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\Workshop\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(573, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(636, 47, false);
#line 26 "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\Workshop\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(683, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(747, 43, false);
#line 29 "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\Workshop\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(790, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(853, 49, false);
#line 32 "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\Workshop\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Prerequisites));

#line default
#line hidden
            EndContext();
            BeginContext(902, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(966, 45, false);
#line 35 "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\Workshop\Details.cshtml"
       Write(Html.DisplayFor(model => model.Prerequisites));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1074, 48, false);
#line 38 "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\Workshop\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Requirements));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1186, 44, false);
#line 41 "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\Workshop\Details.cshtml"
       Write(Html.DisplayFor(model => model.Requirements));

#line default
#line hidden
            EndContext();
            BeginContext(1230, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1293, 51, false);
#line 44 "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\Workshop\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PlacesAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(1344, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1408, 47, false);
#line 47 "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\Workshop\Details.cshtml"
       Write(Html.DisplayFor(model => model.PlacesAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(1455, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1518, 43, false);
#line 50 "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\Workshop\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(1561, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1625, 39, false);
#line 53 "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\Workshop\Details.cshtml"
       Write(Html.DisplayFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(1664, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1727, 45, false);
#line 56 "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\Workshop\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SpeakerId));

#line default
#line hidden
            EndContext();
            BeginContext(1772, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1836, 41, false);
#line 59 "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\Workshop\Details.cshtml"
       Write(Html.DisplayFor(model => model.SpeakerId));

#line default
#line hidden
            EndContext();
            BeginContext(1877, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1940, 52, false);
#line 62 "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\Workshop\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RegistrationLink));

#line default
#line hidden
            EndContext();
            BeginContext(1992, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2056, 48, false);
#line 65 "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\Workshop\Details.cshtml"
       Write(Html.DisplayFor(model => model.RegistrationLink));

#line default
#line hidden
            EndContext();
            BeginContext(2104, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2152, 68, false);
#line 70 "D:\proiect final dotnet\finalproject-bogdanbirsa\Conference\Areas\Admin\Views\Workshop\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2220, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2228, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32fe53b09b5a409fe20ae3446100410b35f23d5a12572", async() => {
                BeginContext(2250, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2266, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Conference.Areas.Admin.Models.WorkshopViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
