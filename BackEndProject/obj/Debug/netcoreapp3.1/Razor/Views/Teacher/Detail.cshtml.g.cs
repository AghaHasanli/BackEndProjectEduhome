#pragma checksum "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99e61065975417d504b965f7569ba5075282143e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Detail), @"mvc.1.0.view", @"/Views/Teacher/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99e61065975417d504b965f7569ba5075282143e", @"/Views/Teacher/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0afadc8596a86b9c4627c9ca3effafa485484268", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://devitems.us11.list-manage.com/subscribe/post?u=6bbb9b6f5827bd842d9640c82&amp;id=05d85f18ef"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("mc-embedded-subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("mc-embedded-subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("validate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Banner Area Start -->
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>teachers / details</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Teacher Start -->
<div class=""teacher-details-area pt-150 pb-60"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5 col-sm-5 col-xs-12"">
                <div class=""teacher-details-img"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "99e61065975417d504b965f7569ba5075282143e6964", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 873, "~/img/teacher/", 873, 14, true);
#nullable restore
#line 30 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
AddHtmlAttributeValue("", 887, Model.TeacherDetail.Teacher.ImageUrl, 887, 37, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-7 col-sm-7 col-xs-12\">\r\n                <div class=\"teacher-details-content ml-50\">\r\n                    <h2>");
#nullable restore
#line 35 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
                   Write(Model.TeacherDetail.Teacher.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h5>");
#nullable restore
#line 36 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
                   Write(Model.TeacherDetail.Teacher.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h4>about me</h4>\r\n                    <p>");
#nullable restore
#line 38 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
                  Write(Model.TeacherDetail.AboutMe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <ul>\r\n                        <li><span>degree: </span>");
#nullable restore
#line 40 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
                                            Write(Model.TeacherDetail.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>experience: </span>");
#nullable restore
#line 41 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
                                                Write(Model.TeacherDetail.Exprience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>hobbies: </span>");
#nullable restore
#line 42 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
                                             Write(Model.TeacherDetail.Hobbies);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>faculty: </span>");
#nullable restore
#line 43 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
                                             Write(Model.TeacherDetail.Faculty);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3 col-sm-4"">
                <div class=""teacher-contact"">
                    <h4>contact information</h4>
                    <p><span>mail me : </span>");
#nullable restore
#line 52 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
                                         Write(Model.TeacherDetail.MailMe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><span>make a call : </span>");
#nullable restore
#line 53 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
                                             Write(Model.TeacherDetail.MakeACall);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><span>skype : </span>");
#nullable restore
#line 54 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
                                       Write(Model.TeacherDetail.Skype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <ul>\r\n");
#nullable restore
#line 56 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
                         foreach (Social s in Model.Socials)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2349, "\"", 2363, 1);
#nullable restore
#line 58 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2356, s.Link, 2356, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 2367, "\"", 2382, 1);
#nullable restore
#line 58 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2375, s.Icon, 2375, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a></li>\r\n");
#nullable restore
#line 59 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </ul>
                </div>
            </div>
            <div class=""col-md-9 col-sm-8"">
                <div class=""skill-area"">
                    <h4>skills</h4>
                </div>
                <div class=""skill-wrapper"">
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>language</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 3035, "\"", 3155, 11);
            WriteAttributeValue("", 3043, "width:", 3043, 6, true);
#nullable restore
#line 74 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 3049, Model, 3050, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3056, ";", 3056, 1, true);
            WriteAttributeValue(" ", 3057, "visibility:", 3058, 12, true);
            WriteAttributeValue(" ", 3069, "visible;", 3070, 9, true);
            WriteAttributeValue(" ", 3078, "animation-duration:", 3079, 20, true);
            WriteAttributeValue(" ", 3098, "1.5s;", 3099, 6, true);
            WriteAttributeValue(" ", 3104, "animation-delay:", 3105, 17, true);
            WriteAttributeValue(" ", 3121, "1.2s;", 3122, 6, true);
            WriteAttributeValue(" ", 3127, "animation-name:", 3128, 16, true);
            WriteAttributeValue(" ", 3143, "fadeInLeft;", 3144, 12, true);
            EndWriteAttribute();
            WriteLiteral(@" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">%</span>
                                    </div>
                                 </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>team leader</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 3748, "\"", 3893, 11);
            WriteAttributeValue("", 3756, "width:", 3756, 6, true);
#nullable restore
#line 84 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 3762, Model.TeacherDetail.TeamLeader, 3763, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3794, ";", 3794, 1, true);
            WriteAttributeValue(" ", 3795, "visibility:", 3796, 12, true);
            WriteAttributeValue(" ", 3807, "visible;", 3808, 9, true);
            WriteAttributeValue(" ", 3816, "animation-duration:", 3817, 20, true);
            WriteAttributeValue(" ", 3836, "1.5s;", 3837, 6, true);
            WriteAttributeValue(" ", 3842, "animation-delay:", 3843, 17, true);
            WriteAttributeValue(" ", 3859, "1.2s;", 3860, 6, true);
            WriteAttributeValue(" ", 3865, "animation-name:", 3866, 16, true);
            WriteAttributeValue(" ", 3881, "fadeInLeft;", 3882, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 85 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
                                                          Write(Model.TeacherDetail.TeamLeader);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>development</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 4515, "\"", 4660, 11);
            WriteAttributeValue("", 4523, "width:", 4523, 6, true);
#nullable restore
#line 94 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 4529, Model.TeacherDetail.Development, 4529, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4561, ";", 4561, 1, true);
            WriteAttributeValue(" ", 4562, "visibility:", 4563, 12, true);
            WriteAttributeValue(" ", 4574, "visible;", 4575, 9, true);
            WriteAttributeValue(" ", 4583, "animation-duration:", 4584, 20, true);
            WriteAttributeValue(" ", 4603, "1.5s;", 4604, 6, true);
            WriteAttributeValue(" ", 4609, "animation-delay:", 4610, 17, true);
            WriteAttributeValue(" ", 4626, "1.2s;", 4627, 6, true);
            WriteAttributeValue(" ", 4632, "animation-name:", 4633, 16, true);
            WriteAttributeValue(" ", 4648, "fadeInLeft;", 4649, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 95 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
                                                          Write(Model.TeacherDetail.Development);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>design</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 5278, "\"", 5418, 11);
            WriteAttributeValue("", 5286, "width:", 5286, 6, true);
#nullable restore
#line 104 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 5292, Model.TeacherDetail.Design, 5292, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5319, ";", 5319, 1, true);
            WriteAttributeValue(" ", 5320, "visibility:", 5321, 12, true);
            WriteAttributeValue(" ", 5332, "visible;", 5333, 9, true);
            WriteAttributeValue(" ", 5341, "animation-duration:", 5342, 20, true);
            WriteAttributeValue(" ", 5361, "1.5s;", 5362, 6, true);
            WriteAttributeValue(" ", 5367, "animation-delay:", 5368, 17, true);
            WriteAttributeValue(" ", 5384, "1.2s;", 5385, 6, true);
            WriteAttributeValue(" ", 5390, "animation-name:", 5391, 16, true);
            WriteAttributeValue(" ", 5406, "fadeInLeft;", 5407, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 105 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
                                                          Write(Model.TeacherDetail.Design);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>innovation</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 6035, "\"", 6180, 11);
            WriteAttributeValue("", 6043, "width:", 6043, 6, true);
#nullable restore
#line 114 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 6049, Model.TeacherDetail.Innovation, 6050, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6081, ";", 6081, 1, true);
            WriteAttributeValue(" ", 6082, "visibility:", 6083, 12, true);
            WriteAttributeValue(" ", 6094, "visible;", 6095, 9, true);
            WriteAttributeValue(" ", 6103, "animation-duration:", 6104, 20, true);
            WriteAttributeValue(" ", 6123, "1.5s;", 6124, 6, true);
            WriteAttributeValue(" ", 6129, "animation-delay:", 6130, 17, true);
            WriteAttributeValue(" ", 6146, "1.2s;", 6147, 6, true);
            WriteAttributeValue(" ", 6152, "animation-name:", 6153, 16, true);
            WriteAttributeValue(" ", 6168, "fadeInLeft;", 6169, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 115 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
                                                          Write(Model.TeacherDetail.Innovation);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>communication</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 6804, "\"", 6952, 11);
            WriteAttributeValue("", 6812, "width:", 6812, 6, true);
#nullable restore
#line 124 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 6818, Model.TeacherDetail.Communication, 6819, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6853, ";", 6853, 1, true);
            WriteAttributeValue(" ", 6854, "visibility:", 6855, 12, true);
            WriteAttributeValue(" ", 6866, "visible;", 6867, 9, true);
            WriteAttributeValue(" ", 6875, "animation-duration:", 6876, 20, true);
            WriteAttributeValue(" ", 6895, "1.5s;", 6896, 6, true);
            WriteAttributeValue(" ", 6901, "animation-delay:", 6902, 17, true);
            WriteAttributeValue(" ", 6918, "1.2s;", 6919, 6, true);
            WriteAttributeValue(" ", 6924, "animation-name:", 6925, 16, true);
            WriteAttributeValue(" ", 6940, "fadeInLeft;", 6941, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 125 "D:\DISC-C-Files\Desktop\BackEndProjectEduhome\BackEndProject\Views\Teacher\Detail.cshtml"
                                                          Write(Model.TeacherDetail.Communication);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Teacher End -->
<!-- Subscribe Start -->
<div class=""subscribe-area pt-60 pb-70"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8 col-md-offset-2"">
                <div class=""subscribe-content section-title text-center"">
                    <h2>subscribe our newsletter</h2>
                    <p>I must explain to you how all this mistaken idea </p>
                </div>
                <div class=""newsletter-form mc_embed_signup"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99e61065975417d504b965f7569ba5075282143e26538", async() => {
                WriteLiteral("\r\n                        <div id=\"mc_embed_signup_scroll\" class=\"mc-form\">\r\n                            <input type=\"email\"");
                BeginWriteAttribute("value", " value=\"", 8252, "\"", 8260, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""EMAIL"" class=""email"" id=""mce-EMAIL"" placeholder=""Enter your e-mail address"" required>
                            <!-- real people should not fill this in and expect good things - do not remove this or risk form bot signups-->
                            <div class=""mc-news"" aria-hidden=""true""><input type=""text"" name=""b_6bbb9b6f5827bd842d9640c82_05d85f18ef"" tabindex=""-1""");
                BeginWriteAttribute("value", " value=\"", 8643, "\"", 8651, 0);
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                            <button id=\"mc-embedded-subscribe\" class=\"default-btn\" type=\"submit\" name=\"subscribe\"><span>subscribe</span></button>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <!-- mailchimp-alerts Start -->
                    <div class=""mailchimp-alerts"">
                        <div class=""mailchimp-submitting""></div><!-- mailchimp-submitting end -->
                        <div class=""mailchimp-success""></div><!-- mailchimp-success end -->
                        <div class=""mailchimp-error""></div><!-- mailchimp-error end -->
                    </div>
                    <!-- mailchimp-alerts end -->
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Subscribe End -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
