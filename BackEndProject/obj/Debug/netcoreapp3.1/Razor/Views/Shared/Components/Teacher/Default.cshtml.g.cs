#pragma checksum "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Shared\Components\Teacher\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea24c0b930a46ca47de6efae7ee23b7345cdffc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Teacher_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Teacher/Default.cshtml")]
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
#line 2 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\_ViewImports.cshtml"
using BackEndProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\_ViewImports.cshtml"
using BackEndProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea24c0b930a46ca47de6efae7ee23b7345cdffc0", @"/Views/Shared/Components/Teacher/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0afadc8596a86b9c4627c9ca3effafa485484268", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Teacher_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Teacher>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Shared\Components\Teacher\Default.cshtml"
 foreach (Teacher tc in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-3 col-sm-4 col-xs-12\">\r\n        <div class=\"single-teacher mb-45\">\r\n            <div class=\"single-teacher-img\">\r\n                <a href=\"teacher-details.html\"><img");
            BeginWriteAttribute("src", " src=\"", 245, "\"", 275, 2);
            WriteAttributeValue("", 251, "img/teacher/", 251, 12, true);
#nullable restore
#line 7 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Shared\Components\Teacher\Default.cshtml"
WriteAttributeValue("", 263, tc.ImageUrl, 263, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"teacher\"></a>\r\n            </div>\r\n            <div class=\"single-teacher-content text-center\">\r\n                <h2><a href=\"teacher-details.html\">");
#nullable restore
#line 10 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Shared\Components\Teacher\Default.cshtml"
                                              Write(tc.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                <h4>");
#nullable restore
#line 11 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Shared\Components\Teacher\Default.cshtml"
               Write(tc.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                <ul>
                    <li><a href=""https://www.facebook.com/devitems/?ref=bookmarks""><i class=""zmdi zmdi-facebook""></i></a></li>
                    <li><a href=""https://www.pinterest.com/devitemsllc/""><i class=""zmdi zmdi-pinterest""></i></a></li>
                    <li><a href=""#""><i class=""zmdi zmdi-vimeo""></i></a></li>
                    <li><a href=""https://twitter.com/devitemsllc""><i class=""zmdi zmdi-twitter""></i></a></li>
                </ul>
            </div>
        </div>
    </div>
");
#nullable restore
#line 21 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Shared\Components\Teacher\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
