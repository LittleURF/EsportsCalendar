#pragma checksum "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\Teams\OpponentsDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80119c241938514e346b213e601cbcdaca362218"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teams_OpponentsDetails), @"mvc.1.0.view", @"/Views/Teams/OpponentsDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teams/OpponentsDetails.cshtml", typeof(AspNetCore.Views_Teams_OpponentsDetails))]
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
using System.Globalization;

#line default
#line hidden
#line 4 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 5 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 6 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\_ViewImports.cshtml"
using RestSharp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80119c241938514e346b213e601cbcdaca362218", @"/Views/Teams/OpponentsDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d6d59a37f1eabcc65e8ae401ae9e9e818a67618", @"/Views/_ViewImports.cshtml")]
    public class Views_Teams_OpponentsDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EsportsCalendar.Models.Team>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Hubert\source\repos\EsportsCalendar\EsportsCalendar\Views\Teams\OpponentsDetails.cshtml"
  
    ViewData["Title"] = "OpponentsDetails";

#line default
#line hidden
            BeginContext(103, 32, true);
            WriteLiteral("<br />\r\n<h2>Details</h2>\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EsportsCalendar.Models.Team>> Html { get; private set; }
    }
}
#pragma warning restore 1591