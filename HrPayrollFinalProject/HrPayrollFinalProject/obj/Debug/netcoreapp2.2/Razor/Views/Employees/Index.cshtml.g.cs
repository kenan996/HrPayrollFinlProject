#pragma checksum "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db9d65e322434a52c851f60981f06d50e89c618a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Index), @"mvc.1.0.view", @"/Views/Employees/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employees/Index.cshtml", typeof(AspNetCore.Views_Employees_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db9d65e322434a52c851f60981f06d50e89c618a", @"/Views/Employees/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad9cb1baaf8ac090f2d4f65f3b809d1dc1332ad2", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Employees>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top imageThumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-blue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4147, 60, true);
            WriteLiteral("\r\n\r\n<!-- Main Content Start -->\r\n<!-- Breadcrumb Start -->\r\n");
            EndContext();
            BeginContext(4515, 1814, true);
            WriteLiteral(@"<!-- Breadcrumb End -->




<div class=""container"">

    <!-- Title Start -->
    <div class=""hk-pg-header"">
        <h4 class=""hk-pg-title""><span class=""pg-title-icon""><span class=""feather-icon""><i data-feather=""database""></i></span></span>Data Tables</h4>
    </div>
    <!-- Title End -->
    <!-- Row Start -->
    <div class=""row"">
        <div class=""col-xl-12"">
            <section class=""hk-sec-wrapper"">
                <h5 class=""hk-sec-title"">Data Table</h5>
                <div class=""row"">
                    <div class=""col-sm"">
                        <div class=""table-wrap"">
                            <table id=""datable_1"" class=""table table-hover w-100 display pb-30"">
                                <thead>
                                    <tr>
                                        <th>Name</th>
                                        <th>Surname</th>
                                        <th>Fathers Name</th>
                                        <th>Birth Da");
            WriteLiteral(@"te</th>
                                        <th>Adress</th>
                                        <th>Influnce</th>
                                        <th>Passport No</th>
                                        <th>Passport Expire Date</th>
                                        <th>Education</th>
                                        <th>Family State</th>
                                        <th>Gender</th>
                                        <th>Photo</th>
                                        <th>Edit</th>
                                        <th>Delete</th>
                                        <th>Details</th>
                                    </tr>
                                </thead>
                                <tbody>
");
            EndContext();
#line 155 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
            BeginContext(6434, 94, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>");
            EndContext();
            BeginContext(6529, 9, false);
#line 158 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(6538, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(6594, 12, false);
#line 159 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Index.cshtml"
                                           Write(item.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(6606, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(6662, 16, false);
#line 160 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Index.cshtml"
                                           Write(item.FathersName);

#line default
#line hidden
            EndContext();
            BeginContext(6678, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(6734, 14, false);
#line 161 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Index.cshtml"
                                           Write(item.BirthDate);

#line default
#line hidden
            EndContext();
            BeginContext(6748, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(6804, 11, false);
#line 162 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Index.cshtml"
                                           Write(item.Adress);

#line default
#line hidden
            EndContext();
            BeginContext(6815, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(6871, 13, false);
#line 163 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Index.cshtml"
                                           Write(item.Influnce);

#line default
#line hidden
            EndContext();
            BeginContext(6884, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(6940, 15, false);
#line 164 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Index.cshtml"
                                           Write(item.PassportNo);

#line default
#line hidden
            EndContext();
            BeginContext(6955, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(7011, 23, false);
#line 165 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Index.cshtml"
                                           Write(item.PassportExpireDate);

#line default
#line hidden
            EndContext();
            BeginContext(7034, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(7090, 14, false);
#line 166 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Index.cshtml"
                                           Write(item.Education);

#line default
#line hidden
            EndContext();
            BeginContext(7104, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(7160, 16, false);
#line 167 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Index.cshtml"
                                           Write(item.FamilyState);

#line default
#line hidden
            EndContext();
            BeginContext(7176, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(7232, 11, false);
#line 168 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Index.cshtml"
                                           Write(item.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(7243, 105, true);
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(7348, 141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "db9d65e322434a52c851f60981f06d50e89c618a14276", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 170 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Index.cshtml"
                                                                                  WriteLiteral(item.Photo);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 171 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Index.cshtml"
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
            BeginContext(7489, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(7640, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db9d65e322434a52c851f60981f06d50e89c618a16723", async() => {
                BeginContext(7706, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 174 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Index.cshtml"
                                                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7714, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(7865, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db9d65e322434a52c851f60981f06d50e89c618a19350", async() => {
                BeginContext(7935, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 177 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Index.cshtml"
                                                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7945, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(8096, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db9d65e322434a52c851f60981f06d50e89c618a21981", async() => {
                BeginContext(8165, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 180 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Index.cshtml"
                                                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8176, 100, true);
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 183 "C:\Users\Kenan\Desktop\FinalProject\HrPayrollFinalProject\HrPayrollFinalProject\Views\Employees\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(8315, 4709, true);
            WriteLiteral(@"                                <tfoot>
                                    <tr>
                                        <th>Name</th>
                                        <th>Surname</th>
                                        <th>Fathers Name</th>
                                        <th>Birth Date</th>
                                        <th>Adress</th>
                                        <th>Influnce</th>
                                        <th>Passport No</th>
                                        <th>Passport Expire Date</th>
                                        <th>Education</th>
                                        <th>Family State</th>
                                        <th>Gender</th>
                                        <th>Photo</th>
                                        <th>Edit</th>
                                        <th>Delete</th>
                                        <th>Details</th>
                                    </tr>
      ");
            WriteLiteral(@"                          </tfoot>
                            </table>
                        </div>
                    </div>
                </div>
            </section>
            <section class=""hk-sec-wrapper"">
                <h5 class=""hk-sec-title"">Export Table</h5>
                <p class=""mb-40"">Use buttons: <code>['copy', 'csv', 'excel', 'pdf', 'print']</code> to add export table options.</p>
                <div class=""row"">
                    <div class=""col-sm"">
                        <div class=""table-wrap"">
                            <table id=""datable_3"" class=""table table-hover w-100 display"">
                                <thead>
                                    <tr>
                                        <th>Name</th>
                                        <th>Position</th>
                                        <th>Office</th>
                                        <th>Age</th>
                                        <th>Start date</th>
              ");
            WriteLiteral(@"                          <th>Salary</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Tiger Nixon</td>
                                        <td>System Architect</td>
                                        <td>Edinburgh</td>
                                        <td>61</td>
                                        <td>2011/04/25</td>
                                        <td>$320,800</td>
                                    </tr>
                                    <tr>
                                        <td>Adwez Nash</td>
                                        <td>Software Engineer</td>
                                        <td>India</td>
                                        <td>38</td>
                                        <td>2014/05/03</td>
                                        <td>$763,500</td>
        ");
            WriteLiteral(@"                            </tr>
                                    <tr>
                                        <td>Garrett Winters</td>
                                        <td>Accountant</td>
                                        <td>Tokyo</td>
                                        <td>63</td>
                                        <td>2011/07/25</td>
                                        <td>$170,750</td>
                                    </tr>
                                    <tr>
                                        <td>Ashton Cox</td>
                                        <td>Junior Technical Author</td>
                                        <td>San Francisco</td>
                                        <td>66</td>
                                        <td>2009/01/12</td>
                                        <td>$86,000</td>
                                    </tr>
                                    <tr>
                                        <td>Cedric");
            WriteLiteral(@" Kelly</td>
                                        <td>Senior Javascript Developer</td>
                                        <td>Edinburgh</td>
                                        <td>22</td>
                                        <td>2012/03/29</td>
                                        <td>$433,060</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    </div>
    <!-- Row End -->

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Employees>> Html { get; private set; }
    }
}
#pragma warning restore 1591
