#pragma checksum "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05580e18773ed945877168959f85f12efe19ef55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Delete), @"mvc.1.0.view", @"/Views/Employees/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employees/Delete.cshtml", typeof(AspNetCore.Views_Employees_Delete))]
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
#line 3 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\_ViewImports.cshtml"
using HrPayrollFinalProject.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05580e18773ed945877168959f85f12efe19ef55", @"/Views/Employees/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b62577884d03f5703f2fe4604a0dd668dbfb1bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HrPayrollFinalProject.Models.Employees>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(138, 179, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Employees</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(318, 40, false);
#line 16 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(358, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(422, 36, false);
#line 19 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(458, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(521, 43, false);
#line 22 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(564, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(628, 39, false);
#line 25 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(667, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(730, 47, false);
#line 28 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FathersName));

#line default
#line hidden
            EndContext();
            BeginContext(777, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(841, 43, false);
#line 31 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FathersName));

#line default
#line hidden
            EndContext();
            BeginContext(884, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(947, 45, false);
#line 34 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(992, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1056, 41, false);
#line 37 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1160, 42, false);
#line 40 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Adress));

#line default
#line hidden
            EndContext();
            BeginContext(1202, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1266, 38, false);
#line 43 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Adress));

#line default
#line hidden
            EndContext();
            BeginContext(1304, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1367, 44, false);
#line 46 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Influnce));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1475, 40, false);
#line 49 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Influnce));

#line default
#line hidden
            EndContext();
            BeginContext(1515, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1578, 46, false);
#line 52 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PassportNo));

#line default
#line hidden
            EndContext();
            BeginContext(1624, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1688, 42, false);
#line 55 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PassportNo));

#line default
#line hidden
            EndContext();
            BeginContext(1730, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1793, 54, false);
#line 58 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PassportExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1847, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1911, 50, false);
#line 61 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PassportExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1961, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2024, 45, false);
#line 64 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Education));

#line default
#line hidden
            EndContext();
            BeginContext(2069, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2133, 41, false);
#line 67 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Education));

#line default
#line hidden
            EndContext();
            BeginContext(2174, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2237, 47, false);
#line 70 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FamilyState));

#line default
#line hidden
            EndContext();
            BeginContext(2284, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2348, 43, false);
#line 73 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FamilyState));

#line default
#line hidden
            EndContext();
            BeginContext(2391, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2454, 42, false);
#line 76 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(2496, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2560, 38, false);
#line 79 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(2598, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2661, 41, false);
#line 82 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo));

#line default
#line hidden
            EndContext();
            BeginContext(2702, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2766, 37, false);
#line 85 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Photo));

#line default
#line hidden
            EndContext();
            BeginContext(2803, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2841, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05580e18773ed945877168959f85f12efe19ef5516266", async() => {
                BeginContext(2867, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2877, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "05580e18773ed945877168959f85f12efe19ef5516659", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 90 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2913, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2996, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05580e18773ed945877168959f85f12efe19ef5518595", async() => {
                    BeginContext(3018, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3034, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3047, 10, true);
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
