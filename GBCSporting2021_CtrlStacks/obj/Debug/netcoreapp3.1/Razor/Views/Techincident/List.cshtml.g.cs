#pragma checksum "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de8ca5cc249baaa2e191ba03e1e155c893548176"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Techincident_List), @"mvc.1.0.view", @"/Views/Techincident/List.cshtml")]
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
#nullable restore
#line 1 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\_ViewImports.cshtml"
using GBCSporting2021_CtrlStacks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\_ViewImports.cshtml"
using GBCSporting2021_CtrlStacks.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
using PagedList.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de8ca5cc249baaa2e191ba03e1e155c893548176", @"/Views/Techincident/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27697e26bce1cb21c1fb9f8729ca25951a2bc551", @"/Views/_ViewImports.cshtml")]
    public class Views_Techincident_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Incident>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "techincident", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pager-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "list", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
  
    ViewData["Title"] = "List incidents for Technician: " + ViewBag.Technician;
    var msgSuccess = (string)TempData["Message"];

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
 if (!string.IsNullOrEmpty(msgSuccess))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"msg-temp-success\">\r\n        <h1 class=\"p-2\">");
#nullable restore
#line 11 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
                   Write(msgSuccess);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n");
#nullable restore
#line 13 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h2>Technician: ");
#nullable restore
#line 16 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
                   Write(ViewBag.Technician);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
        <h2>Assigned/Open Incidents</h2>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12"">
        <table class=""table table-bordered table-striped"">
            <thead>
                <tr>
                    <th>Title</th>
                    <th>Customer</th>
                    <th>Product</th>
                    <th>Date Opened</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 34 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
                 if (Model.Any())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
                     foreach (var incident in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td><p>");
#nullable restore
#line 39 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
                              Write(incident.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                            <td><p>");
#nullable restore
#line 40 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
                              Write(incident.Customer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 40 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
                                                           Write(incident.Customer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                            <td><p>");
#nullable restore
#line 41 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
                              Write(incident.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                            <td><p>");
#nullable restore
#line 42 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
                              Write(string.Format("{0:MM/dd/yyyy}", incident.DateOpened));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                            <td class=\"text-right\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de8ca5cc249baaa2e191ba03e1e155c89354817611529", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
                                                                                                                  WriteLiteral(incident.IncidentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 47 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"5\" class=\"text-center\">\r\n                            <p class=\"text-danger mb-0\">There are no <b>incident Items</b></p>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 56 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 d-md-flex\">\r\n        <div class=\"me-auto pt-1\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de8ca5cc249baaa2e191ba03e1e155c89354817615637", async() => {
                WriteLiteral("Switch Technician");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"pt-1\">\r\n");
#nullable restore
#line 67 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
              
                var pageListOpt = PagedListRenderOptions.Bootstrap4PageNumbersOnly;
                pageListOpt.UlElementClasses = new[] { "pagination justify-content-end" };
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "de8ca5cc249baaa2e191ba03e1e155c89354817617654", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 72 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 73 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.Options = pageListOpt;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("options", __PagedList_Core_Mvc_PagerTagHelper.Options, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__PagedList_Core_Mvc_PagerTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "PagedList.Core.Mvc.PagerTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
                       WriteLiteral(ViewBag.Page);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __PagedList_Core_Mvc_PagerTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __PagedList_Core_Mvc_PagerTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "D:\GBC Course\Sem4-2021\COMP 2139 - WEB APPLICATION DEVELOPMENT\Assignment\Clone\v2\GBCSporting2021_CtrlStacks\Final Copy\GBCSporting2021_CtrlStacks\Views\Techincident\List.cshtml"
                                                         WriteLiteral(ViewBag.PerPage);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __PagedList_Core_Mvc_PagerTagHelper.RouteValues["perpage"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-perpage", __PagedList_Core_Mvc_PagerTagHelper.RouteValues["perpage"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Incident>> Html { get; private set; }
    }
}
#pragma warning restore 1591
