#pragma checksum "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f827c7fd02746a523fda79c0c2c8e915d580fa93"
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
using HrPayrollFinalProject.ViewModel;

#line default
#line hidden
#line 4 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\_ViewImports.cshtml"
using HrPayrollFinalProject.Controllers;

#line default
#line hidden
#line 5 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\_ViewImports.cshtml"
using HrPayrollFinalProject.Utilities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f827c7fd02746a523fda79c0c2c8e915d580fa93", @"/Views/Employees/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad9cb1baaf8ac090f2d4f65f3b809d1dc1332ad2", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HrPayrollFinalProject.Models.Employees>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
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
            BeginContext(138, 177, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Employees</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(316, 40, false);
#line 16 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(356, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(418, 36, false);
#line 19 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(454, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(515, 43, false);
#line 22 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(558, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(620, 39, false);
#line 25 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(659, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(720, 47, false);
#line 28 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FathersName));

#line default
#line hidden
            EndContext();
            BeginContext(767, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(829, 43, false);
#line 31 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FathersName));

#line default
#line hidden
            EndContext();
            BeginContext(872, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(933, 45, false);
#line 34 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(978, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1040, 41, false);
#line 37 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1142, 42, false);
#line 40 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Adress));

#line default
#line hidden
            EndContext();
            BeginContext(1184, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1246, 38, false);
#line 43 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Adress));

#line default
#line hidden
            EndContext();
            BeginContext(1284, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1345, 44, false);
#line 46 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Influnce));

#line default
#line hidden
            EndContext();
            BeginContext(1389, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1451, 40, false);
#line 49 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Influnce));

#line default
#line hidden
            EndContext();
            BeginContext(1491, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1552, 46, false);
#line 52 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PassportNo));

#line default
#line hidden
            EndContext();
            BeginContext(1598, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1660, 42, false);
#line 55 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PassportNo));

#line default
#line hidden
            EndContext();
            BeginContext(1702, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1763, 54, false);
#line 58 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PassportExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1817, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1879, 50, false);
#line 61 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PassportExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1929, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1990, 45, false);
#line 64 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Education));

#line default
#line hidden
            EndContext();
            BeginContext(2035, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2097, 41, false);
#line 67 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Education));

#line default
#line hidden
            EndContext();
            BeginContext(2138, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2199, 47, false);
#line 70 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FamilyState));

#line default
#line hidden
            EndContext();
            BeginContext(2246, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2308, 43, false);
#line 73 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FamilyState));

#line default
#line hidden
            EndContext();
            BeginContext(2351, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2412, 42, false);
#line 76 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(2454, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2516, 38, false);
#line 79 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(2554, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2615, 41, false);
#line 82 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo));

#line default
#line hidden
            EndContext();
            BeginContext(2656, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2717, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f827c7fd02746a523fda79c0c2c8e915d580fa9317506", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/img/");
#line 85 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
                                                                        WriteLiteral(Model.ImageUrl);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 85 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2833, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2871, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f827c7fd02746a523fda79c0c2c8e915d580fa9320328", async() => {
                BeginContext(2897, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2907, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f827c7fd02746a523fda79c0c2c8e915d580fa9320721", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
                BeginContext(2943, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(3026, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f827c7fd02746a523fda79c0c2c8e915d580fa9322657", async() => {
                    BeginContext(3048, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3064, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3077, 10, true);
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
