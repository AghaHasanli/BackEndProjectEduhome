#pragma checksum "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\EventAdmin\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "455088e26cb966e3a1fd8071dc1df5c517a545ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_EventAdmin_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/EventAdmin/Detail.cshtml")]
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
#line 2 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\_ViewImports.cshtml"
using BackEndProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\_ViewImports.cshtml"
using BackEndProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"455088e26cb966e3a1fd8071dc1df5c517a545ec", @"/Areas/Admin/Views/EventAdmin/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0afadc8596a86b9c4627c9ca3effafa485484268", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_EventAdmin_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Event>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "EventAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:120px; height:115px; object-fit:cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 140px; height: 140px; object-fit:cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\EventAdmin\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">Course</h4>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "455088e26cb966e3a1fd8071dc1df5c517a545ec6227", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            WriteLiteral(@"
                <div class=""table-responsive"">
                    <table class=""table table-striped"">
                        <thead>
                            <tr>
                                <th>
                                    Image
                                </th>
                                <th>
                                    Description
                                </th>
                                <th>
                                    Event
                                </th>
                                <th>
                                    Time
                                </th>
                                <th>
                                    Venue
                                </th>

                                <th>
                                    Speakers
                                </th>
                                <th>
                                    Settings
                                </th");
            WriteLiteral(">\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n                            <tr>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "455088e26cb966e3a1fd8071dc1df5c517a545ec8953", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1598, "~/img/event/", 1598, 12, true);
#nullable restore
#line 43 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\EventAdmin\Detail.cshtml"
AddHtmlAttributeValue("", 1610, Model.ImageUrl, 1610, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </td>
                                <td>
                                    <!-- Button trigger modal -->
                                    <button type=""button"" class=""btn btn-secondary"" data-toggle=""modal"" data-target=""#exampleModalLong"">
                                        Click for Description
                                    </button>

                                    <!-- Modal -->
                                    <div class=""modal fade"" id=""#exampleModalLong"" tabindex=""-1"" role=""dialog"" aria-labelledby=""#exampleModalLong"" aria-hidden=""true"">
                                        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                                            <div class=""modal-content"">
                                                <div class=""modal-header"">
                                                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">Modal title</h5>
                                ");
            WriteLiteral(@"                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                        <span aria-hidden=""true"">&times;</span>
                                                    </button>
                                                </div>
                                                <div class=""modal-body"">
                                                    ");
#nullable restore
#line 62 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\EventAdmin\Detail.cshtml"
                                               Write(Html.Raw(Model.EventDetail.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </div>
                                                <div class=""modal-footer"">
                                                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                                    <button type=""button"" class=""btn btn-primary"">Save changes</button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </td>
                                <td>
                                    <h5>
                                        ");
#nullable restore
#line 74 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\EventAdmin\Detail.cshtml"
                                   Write(Model.Lesson);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </h5>\r\n                                </td>\r\n                                <td>\r\n                                    <h5> ");
#nullable restore
#line 78 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\EventAdmin\Detail.cshtml"
                                    Write(Model.EventTime.ToString("dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 78 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\EventAdmin\Detail.cshtml"
                                                                    Write(Model.EventTime.ToString("MMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 78 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\EventAdmin\Detail.cshtml"
                                                                                                     Write(Model.EventTime.ToString("t"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 78 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\EventAdmin\Detail.cshtml"
                                                                                                                                      Write(Model.EventEndTime.ToString("t"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>

                                </td>
                                <td>
                                    <!-- Button trigger modal -->
                                    <button type=""button"" class=""btn btn-secondary"" data-toggle=""modal"" data-target=""#exampleModalCenter"">
                                        Click for Venue
                                    </button>

                                    <!-- Modal -->
                                    <div class=""modal fade"" id=""#exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""#exampleModalCenter"" aria-hidden=""true"">
                                        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                                            <div class=""modal-content"">
                                                <div class=""modal-header"">
                                                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">Modal title</h5>
                         ");
            WriteLiteral(@"                           <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                        <span aria-hidden=""true"">&times;</span>
                                                    </button>
                                                </div>
                                                <div class=""modal-body"">
                                                    ");
#nullable restore
#line 98 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\EventAdmin\Detail.cshtml"
                                               Write(Model.Venue);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 98 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\EventAdmin\Detail.cshtml"
                                                            Write(Model.EventDetail.ExactLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </div>
                                                <div class=""modal-footer"">
                                                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                                    <button type=""button"" class=""btn btn-primary"">Save changes</button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </td>
                                <td>
                                    <!-- Button trigger modal -->
                                    <button type=""button"" class=""btn btn-secondary"" data-toggle=""modal"" data-target=""#speaker-");
#nullable restore
#line 110 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\EventAdmin\Detail.cshtml"
                                                                                                                         Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                        Click for Speakers\r\n                                    </button>\r\n\r\n                                    <!-- Modal -->\r\n                                    <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 6854, "\"", 6876, 2);
            WriteAttributeValue("", 6859, "speaker-", 6859, 8, true);
#nullable restore
#line 115 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\EventAdmin\Detail.cshtml"
WriteAttributeValue("", 6867, Model.Id, 6867, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" role=\"dialog\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 6905, "\"", 6940, 2);
            WriteAttributeValue("", 6923, "speaker-", 6923, 8, true);
#nullable restore
#line 115 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\EventAdmin\Detail.cshtml"
WriteAttributeValue("", 6931, Model.Id, 6931, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-hidden=""true"">
                                        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                                            <div class=""modal-content"">
                                                <div class=""modal-header"">
                                                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">Modal title</h5>
                                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                        <span aria-hidden=""true"">&times;</span>
                                                    </button>
                                                </div>
                                                <div class=""modal-body"">
");
#nullable restore
#line 125 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\EventAdmin\Detail.cshtml"
                                                     foreach (EventSpeaker es in Model.EventSpeakers)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <div class=\"row mt-5\">\r\n                                                            <div class=\"col-6\">\r\n                                                                ");
#nullable restore
#line 129 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\EventAdmin\Detail.cshtml"
                                                           Write(Html.Raw("<p>Speaker Name</p>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                <h3>");
#nullable restore
#line 130 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\EventAdmin\Detail.cshtml"
                                                               Write(es.Speaker.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                                                ");
#nullable restore
#line 131 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\EventAdmin\Detail.cshtml"
                                                           Write(Html.Raw("<p>Speaker Occupation</p>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                <h3>");
#nullable restore
#line 132 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\EventAdmin\Detail.cshtml"
                                                               Write(es.Speaker.Occupation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                                            </div>\r\n                                                            <div class=\"col-6\">\r\n                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "455088e26cb966e3a1fd8071dc1df5c517a545ec22717", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8749, "~/img/event/", 8749, 12, true);
#nullable restore
#line 135 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\EventAdmin\Detail.cshtml"
AddHtmlAttributeValue("", 8761, es.Speaker.ImageUrl, 8761, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("a", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                            </div>\r\n                                                        </div>\r\n");
#nullable restore
#line 138 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\EventAdmin\Detail.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </div>
                                                <div class=""modal-footer"">
                                                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                                    <button type=""button"" class=""btn btn-primary"">Save changes</button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </td>
                                <td>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "455088e26cb966e3a1fd8071dc1df5c517a545ec25746", async() => {
                WriteLiteral("\r\n                                        Edit\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 149 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\EventAdmin\Detail.cshtml"
                                                                                     WriteLiteral(Model.Id);

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
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Event> Html { get; private set; }
    }
}
#pragma warning restore 1591
