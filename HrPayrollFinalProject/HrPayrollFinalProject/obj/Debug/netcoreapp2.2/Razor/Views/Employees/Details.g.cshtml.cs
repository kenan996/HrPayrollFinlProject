#pragma checksum "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4de58ebecdbee4b2a511380071627af61bb9b478"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Details), @"mvc.1.0.view", @"/Views/Employees/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employees/Details.cshtml", typeof(AspNetCore.Views_Employees_Details))]
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
#line 1 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\_ViewImports.cshtml"
using HrPayrollFinalProject;

#line default
#line hidden
#line 2 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\_ViewImports.cshtml"
using HrPayrollFinalProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4de58ebecdbee4b2a511380071627af61bb9b478", @"/Views/Employees/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab7ec4e9fa8e24b6c73687082bff9b151340b6df", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HrPayrollFinalProject.Models.Employees>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-blue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(139, 132, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Employees</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(272, 40, false);
#line 15 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(312, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(376, 36, false);
#line 18 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(412, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(475, 43, false);
#line 21 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(518, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(582, 39, false);
#line 24 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(621, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(684, 47, false);
#line 27 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FathersName));

#line default
#line hidden
            EndContext();
            BeginContext(731, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(795, 43, false);
#line 30 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.FathersName));

#line default
#line hidden
            EndContext();
            BeginContext(838, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(901, 45, false);
#line 33 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(946, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1010, 41, false);
#line 36 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1114, 42, false);
#line 39 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Adress));

#line default
#line hidden
            EndContext();
            BeginContext(1156, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1220, 38, false);
#line 42 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Adress));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1321, 44, false);
#line 45 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Influnce));

#line default
#line hidden
            EndContext();
            BeginContext(1365, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1429, 40, false);
#line 48 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Influnce));

#line default
#line hidden
            EndContext();
            BeginContext(1469, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1532, 46, false);
#line 51 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PassportNo));

#line default
#line hidden
            EndContext();
            BeginContext(1578, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1642, 42, false);
#line 54 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.PassportNo));

#line default
#line hidden
            EndContext();
            BeginContext(1684, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1747, 54, false);
#line 57 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PassportExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1801, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1865, 50, false);
#line 60 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.PassportExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1915, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1978, 45, false);
#line 63 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Education));

#line default
#line hidden
            EndContext();
            BeginContext(2023, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2087, 41, false);
#line 66 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Education));

#line default
#line hidden
            EndContext();
            BeginContext(2128, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2191, 47, false);
#line 69 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FamilyState));

#line default
#line hidden
            EndContext();
            BeginContext(2238, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2302, 43, false);
#line 72 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.FamilyState));

#line default
#line hidden
            EndContext();
            BeginContext(2345, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2408, 42, false);
#line 75 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(2450, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2514, 38, false);
#line 78 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(2552, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2615, 41, false);
#line 81 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo));

#line default
#line hidden
            EndContext();
            BeginContext(2656, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2720, 37, false);
#line 84 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Photo));

#line default
#line hidden
            EndContext();
            BeginContext(2757, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2804, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4de58ebecdbee4b2a511380071627af61bb9b47816065", async() => {
                BeginContext(2871, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 89 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2879, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2887, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4de58ebecdbee4b2a511380071627af61bb9b47818501", async() => {
                BeginContext(2929, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2945, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HrPayrollFinalProject.Models.Employees> Html { get; private set; }
    }
}
#pragma warning restore 1591
