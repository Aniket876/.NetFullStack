#pragma checksum "C:\Users\ADHANAIT\source\repos\Rolloffsample\Rolloffsample\Views\RollOff\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ed2fe6fef6f4583af622b73b2b0f6a9a05c144b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RollOff_Search), @"mvc.1.0.view", @"/Views/RollOff/Search.cshtml")]
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
#line 1 "C:\Users\ADHANAIT\source\repos\Rolloffsample\Rolloffsample\Views\_ViewImports.cshtml"
using Rolloffsample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADHANAIT\source\repos\Rolloffsample\Rolloffsample\Views\_ViewImports.cshtml"
using Rolloffsample.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ed2fe6fef6f4583af622b73b2b0f6a9a05c144b", @"/Views/RollOff/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37d73a7ca92b336ab243585d31ba50aa4a546e19", @"/Views/_ViewImports.cshtml")]
    public class Views_RollOff_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Rolloffsample.Models.RollOffTable>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"    <br />
    <br />
    <table class=""table"">
        <thead>
            <tr>
                <th>Country</th>
                <th>Global Group Id</th>
                <th>Name</th>
                <th>Local Grade</th>
            </tr>
        </thead>
        <tbody>
                <tr>
                    <td>");
#nullable restore
#line 20 "C:\Users\ADHANAIT\source\repos\Rolloffsample\Rolloffsample\Views\RollOff\Search.cshtml"
                   Write(Html.DisplayFor(model=>model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>model.GlobalGroupId</td>\r\n                    <td>model.Name</td>\r\n                    <td>model.LocalGrade</td>\r\n                </tr>\r\n        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rolloffsample.Models.RollOffTable> Html { get; private set; }
    }
}
#pragma warning restore 1591
