#pragma checksum "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\Shared\_TeamDetailsPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2105b30f56d7c38ab48099cc99e917e75b025266"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TeamDetailsPartialView), @"mvc.1.0.view", @"/Views/Shared/_TeamDetailsPartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_TeamDetailsPartialView.cshtml", typeof(AspNetCore.Views_Shared__TeamDetailsPartialView))]
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
#line 1 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\_ViewImports.cshtml"
using EsportsCalendar;

#line default
#line hidden
#line 2 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\_ViewImports.cshtml"
using EsportsCalendar.Models;

#line default
#line hidden
#line 3 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\_ViewImports.cshtml"
using EsportsCalendar.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#line 5 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 6 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 7 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\_ViewImports.cshtml"
using RestSharp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2105b30f56d7c38ab48099cc99e917e75b025266", @"/Views/Shared/_TeamDetailsPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e72b0811e6e3628adb7cd820726f3f6cac6b005", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TeamDetailsPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EsportsCalendar.Models.Team>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 129, true);
            WriteLiteral("\r\n<div>\r\n    <div class=\"card bg-light text-center d-flex justify-content-center h-100\" style=\"border: 2px solid #858585;\">\r\n\r\n\r\n");
            EndContext();
#line 7 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\Shared\_TeamDetailsPartialView.cshtml"
           var imgSrc = (String.IsNullOrWhiteSpace(Model.ImageUrl)) ? "/images/ImgNotFound.png" : Model.ImageUrl; 

#line default
#line hidden
            BeginContext(282, 82, true);
            WriteLiteral("        <img class=\"card-img-top mt-1\" style=\"height: 100px; object-fit: contain;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 364, "\"", 377, 1);
#line 8 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\Shared\_TeamDetailsPartialView.cshtml"
WriteAttributeValue("", 370, imgSrc, 370, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(378, 79, true);
            WriteLiteral(" />\r\n\r\n\r\n        <div class=\"card-body\">\r\n            <h3 class=\"text-muted\">\r\n");
            EndContext();
#line 13 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\Shared\_TeamDetailsPartialView.cshtml"
                 if (Model.Acronym != @Model.Name && Model.Acronym != null)
                {

#line default
#line hidden
            BeginContext(553, 26, true);
            WriteLiteral("                    <span>");
            EndContext();
            BeginContext(580, 13, false);
#line 15 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\Shared\_TeamDetailsPartialView.cshtml"
                     Write(Model.Acronym);

#line default
#line hidden
            EndContext();
            BeginContext(593, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 16 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\Shared\_TeamDetailsPartialView.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(662, 62, true);
            WriteLiteral("                    <span style=\"white-space: pre;\"> </span>\r\n");
            EndContext();
#line 20 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\Shared\_TeamDetailsPartialView.cshtml"
                }

#line default
#line hidden
            BeginContext(743, 54, true);
            WriteLiteral("            </h3>\r\n            <h2 class=\"card-title\">");
            EndContext();
            BeginContext(798, 10, false);
#line 22 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\Shared\_TeamDetailsPartialView.cshtml"
                              Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(808, 58, true);
            WriteLiteral("</h2>\r\n            <h6 class=\"card-subtitle text-muted\">\r\n");
            EndContext();
#line 24 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\Shared\_TeamDetailsPartialView.cshtml"
                  var gameName = Model.CurrentVideogame.Name == "LoL" ? "League of Legends" : Model.CurrentVideogame.Name;

#line default
#line hidden
            BeginContext(991, 22, true);
            WriteLiteral("                <span>");
            EndContext();
            BeginContext(1014, 8, false);
#line 25 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\Shared\_TeamDetailsPartialView.cshtml"
                 Write(gameName);

#line default
#line hidden
            EndContext();
            BeginContext(1022, 48, true);
            WriteLiteral("</span>\r\n            </h6>\r\n            <br />\r\n");
            EndContext();
#line 28 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\Shared\_TeamDetailsPartialView.cshtml"
             if (Model.Players.Count() == 0)
            {

#line default
#line hidden
            BeginContext(1131, 53, true);
            WriteLiteral("                <span>Players info not found</span>\r\n");
            EndContext();
#line 31 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\Shared\_TeamDetailsPartialView.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1232, 92, true);
            WriteLiteral("                <ul class=\"list-group list-unstyled\" style=\"border-top:1px solid #e0e0e0\">\r\n");
            EndContext();
#line 35 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\Shared\_TeamDetailsPartialView.cshtml"
                     foreach (var player in Model.Players)
                    {

#line default
#line hidden
            BeginContext(1407, 58, true);
            WriteLiteral("                        <li class=\"font-weight-bold mt-3\">");
            EndContext();
            BeginContext(1466, 11, false);
#line 37 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\Shared\_TeamDetailsPartialView.cshtml"
                                                     Write(player.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1477, 54, true);
            WriteLiteral("</li>\r\n                        <li class=\"text-muted\">");
            EndContext();
            BeginContext(1532, 15, false);
#line 38 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\Shared\_TeamDetailsPartialView.cshtml"
                                          Write(player.Hometown);

#line default
#line hidden
            EndContext();
            BeginContext(1547, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 39 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\Shared\_TeamDetailsPartialView.cshtml"
                    }

#line default
#line hidden
            BeginContext(1577, 23, true);
            WriteLiteral("                </ul>\r\n");
            EndContext();
#line 41 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\Shared\_TeamDetailsPartialView.cshtml"
            }

#line default
#line hidden
            BeginContext(1615, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EsportsCalendar.Models.Team> Html { get; private set; }
    }
}
#pragma warning restore 1591
