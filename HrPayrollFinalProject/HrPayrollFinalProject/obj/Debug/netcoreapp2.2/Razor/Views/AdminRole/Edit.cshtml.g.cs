#pragma checksum "C:\Users\kbehb\OneDrive\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\AdminRole\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43330868aabea028755f71ab5c3795a375cdc28b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminRole_Edit), @"mvc.1.0.view", @"/Views/AdminRole/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminRole/Edit.cshtml", typeof(AspNetCore.Views_AdminRole_Edit))]
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
#line 1 "C:\Users\kbehb\OneDrive\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\_ViewImports.cshtml"
using HrPayrollFinalProject;

#line default
#line hidden
#line 2 "C:\Users\kbehb\OneDrive\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\_ViewImports.cshtml"
using HrPayrollFinalProject.Models;

#line default
#line hidden
#line 3 "C:\Users\kbehb\OneDrive\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\_ViewImports.cshtml"
using HrPayrollFinalProject.ViewModel;

#line default
#line hidden
#line 4 "C:\Users\kbehb\OneDrive\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\_ViewImports.cshtml"
using HrPayrollFinalProject.Controllers;

#line default
#line hidden
#line 5 "C:\Users\kbehb\OneDrive\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\_ViewImports.cshtml"
using HrPayrollFinalProject.Utilities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43330868aabea028755f71ab5c3795a375cdc28b", @"/Views/AdminRole/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb5ab2bc852be9c02d89f1ffdd0de3ace9d8d7a9", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminRole_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleModelDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-brown"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\kbehb\OneDrive\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\AdminRole\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(65, 70, true);
            WriteLiteral("\r\n<div class=\"text-black p-1 m-1\">\r\n    <h2>Role List</h2>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(135, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43330868aabea028755f71ab5c3795a375cdc28b6233", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 10 "C:\Users\kbehb\OneDrive\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\AdminRole\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(201, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(205, 1633, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43330868aabea028755f71ab5c3795a375cdc28b7983", async() => {
                BeginContext(243, 42, true);
                WriteLiteral("\r\n\r\n    <input type=\"hidden\" name=\"RoleId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 285, "\"", 307, 1);
#line 14 "C:\Users\kbehb\OneDrive\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\AdminRole\Edit.cshtml"
WriteAttributeValue("", 293, Model.Role.Id, 293, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(308, 45, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"RoleName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 353, "\"", 377, 1);
#line 15 "C:\Users\kbehb\OneDrive\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\AdminRole\Edit.cshtml"
WriteAttributeValue("", 361, Model.Role.Name, 361, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(378, 63, true);
                WriteLiteral(" />\r\n\r\n    <h6 class=\"bg-info text-white p-1\">\r\n        Add to ");
                EndContext();
                BeginContext(442, 15, false);
#line 18 "C:\Users\kbehb\OneDrive\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\AdminRole\Edit.cshtml"
          Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(457, 66, true);
                WriteLiteral("\r\n    </h6>\r\n\r\n    <table class=\"table table-bordered table-sm\">\r\n");
                EndContext();
#line 22 "C:\Users\kbehb\OneDrive\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\AdminRole\Edit.cshtml"
         if (Model.NonMembers.Count() == 0)
        {

#line default
#line hidden
                BeginContext(579, 98, true);
                WriteLiteral("            <tr>\r\n                <td colspan=\"2\">All users are memebers</td>\r\n            </tr>\r\n");
                EndContext();
#line 27 "C:\Users\kbehb\OneDrive\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\AdminRole\Edit.cshtml"
        }
        else
        {
            foreach (var item in Model.NonMembers)
            {

#line default
#line hidden
                BeginContext(780, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(827, 13, false);
#line 33 "C:\Users\kbehb\OneDrive\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\AdminRole\Edit.cshtml"
                   Write(item.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(840, 94, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        <input type=\"checkbox\" name=\"IdToAdd\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 934, "\"", 950, 1);
#line 35 "C:\Users\kbehb\OneDrive\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\AdminRole\Edit.cshtml"
WriteAttributeValue("", 942, item.Id, 942, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(951, 55, true);
                WriteLiteral(" />\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 38 "C:\Users\kbehb\OneDrive\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\AdminRole\Edit.cshtml"
            }
        }

#line default
#line hidden
                BeginContext(1032, 75, true);
                WriteLiteral("    </table>\r\n\r\n    <h6 class=\"bg-info text-white p-1\">\r\n        Delete to ");
                EndContext();
                BeginContext(1108, 15, false);
#line 43 "C:\Users\kbehb\OneDrive\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\AdminRole\Edit.cshtml"
             Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1123, 66, true);
                WriteLiteral("\r\n    </h6>\r\n\r\n    <table class=\"table table-bordered table-sm\">\r\n");
                EndContext();
#line 47 "C:\Users\kbehb\OneDrive\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\AdminRole\Edit.cshtml"
         if (Model.Members.Count() == 0)
        {

#line default
#line hidden
                BeginContext(1242, 96, true);
                WriteLiteral("            <tr>\r\n                <td colspan=\"2\">No users are members</td>\r\n            </tr>\r\n");
                EndContext();
#line 52 "C:\Users\kbehb\OneDrive\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\AdminRole\Edit.cshtml"
        }
        else
        {
            foreach (var item in Model.Members)
            {

#line default
#line hidden
                BeginContext(1438, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(1485, 13, false);
#line 58 "C:\Users\kbehb\OneDrive\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\AdminRole\Edit.cshtml"
                   Write(item.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(1498, 97, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        <input type=\"checkbox\" name=\"IdToDelete\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1595, "\"", 1611, 1);
#line 60 "C:\Users\kbehb\OneDrive\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\AdminRole\Edit.cshtml"
WriteAttributeValue("", 1603, item.Id, 1603, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1612, 55, true);
                WriteLiteral(" />\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 63 "C:\Users\kbehb\OneDrive\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\AdminRole\Edit.cshtml"
            }
        }

#line default
#line hidden
                BeginContext(1693, 82, true);
                WriteLiteral("\r\n    </table>\r\n    <input type=\"submit\" class=\"btn btn-blue\" value=\"Save\"/>\r\n    ");
                EndContext();
                BeginContext(1775, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43330868aabea028755f71ab5c3795a375cdc28b14856", async() => {
                    BeginContext(1819, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1829, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1838, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleModelDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
