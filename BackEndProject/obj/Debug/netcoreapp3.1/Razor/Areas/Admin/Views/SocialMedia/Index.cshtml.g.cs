#pragma checksum "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\SocialMedia\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2aec1da84576ad26c6803ea5ca2b616963c46771"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SocialMedia_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SocialMedia/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aec1da84576ad26c6803ea5ca2b616963c46771", @"/Areas/Admin/Views/SocialMedia/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0afadc8596a86b9c4627c9ca3effafa485484268", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SocialMedia_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Teacher>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SocialMedia", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100px; height: 100px; object-fit:cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\SocialMedia\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12 grid-margin stretch-card \">\r\n        <div class=\"card \">\r\n            <div class=\"card-body \">\r\n                <h4 class=\"card-title\">Teachers</h4>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2aec1da84576ad26c6803ea5ca2b616963c467715200", async() => {
                WriteLiteral("Create");
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
                    <table class=""table table-striped "">
                        <thead>
                            <tr>
                                <th>
                                    Image
                                </th>
                                <th>
                                    Fullname
                                </th>
                                <th>
                                    Icons
                                </th>

                            </tr>

                        </thead>
                        <tbody>
");
#nullable restore
#line 30 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\SocialMedia\Index.cshtml"
                             foreach (Teacher t in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2aec1da84576ad26c6803ea5ca2b616963c467717719", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1280, "~/img/teacher/", 1280, 14, true);
#nullable restore
#line 34 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\SocialMedia\Index.cshtml"
AddHtmlAttributeValue("", 1294, t.ImageUrl, 1294, 11, false);

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
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 37 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\SocialMedia\Index.cshtml"
                                   Write(t.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </td>
                                    <td>
                                            <!-- Button trigger modal -->
                                            <button type=""button"" class=""btn btn-secondary"" data-toggle=""modal"" data-target=""#speaker-");
#nullable restore
#line 41 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\SocialMedia\Index.cshtml"
                                                                                                                                 Write(t.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                                Icons\r\n                                            </button>\r\n\r\n\r\n                                            <!-- Modal -->\r\n                                            <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 1995, "\"", 2013, 2);
            WriteAttributeValue("", 2000, "speaker-", 2000, 8, true);
#nullable restore
#line 47 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\SocialMedia\Index.cshtml"
WriteAttributeValue("", 2008, t.Id, 2008, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" role=\"dialog\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 2042, "\"", 2073, 2);
            WriteAttributeValue("", 2060, "speaker-", 2060, 8, true);
#nullable restore
#line 47 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\SocialMedia\Index.cshtml"
WriteAttributeValue("", 2068, t.Id, 2068, 5, false);

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
#line 58 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\SocialMedia\Index.cshtml"
                                                                 foreach (Social tc in t.Socials)
                                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                    <a class=\"icon-asd\"");
            BeginWriteAttribute("href", " href=\"", 3278, "\"", 3293, 1);
#nullable restore
#line 60 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\SocialMedia\Index.cshtml"
WriteAttributeValue("", 3285, tc.Link, 3285, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 3297, "\"", 3313, 1);
#nullable restore
#line 60 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\SocialMedia\Index.cshtml"
WriteAttributeValue("", 3305, tc.Icon, 3305, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n");
#nullable restore
#line 61 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\SocialMedia\Index.cshtml"
                                                                }

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
                                </tr>
");
#nullable restore
#line 73 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Areas\Admin\Views\SocialMedia\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Teacher>> Html { get; private set; }
    }
}
#pragma warning restore 1591
