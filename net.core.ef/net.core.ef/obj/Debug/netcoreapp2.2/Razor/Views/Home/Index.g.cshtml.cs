#pragma checksum "D:\工作\C#\NetCore-ef\net.core.ef\net.core.ef\net.core.ef\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af697f4c9c16535d2ac94ce5786659933382d24f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\工作\C#\NetCore-ef\net.core.ef\net.core.ef\net.core.ef\Views\_ViewImports.cshtml"
using net.core.ef;

#line default
#line hidden
#line 2 "D:\工作\C#\NetCore-ef\net.core.ef\net.core.ef\net.core.ef\Views\_ViewImports.cshtml"
using net.core.ef.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af697f4c9c16535d2ac94ce5786659933382d24f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13c5aa984c73e418822b6ccb732d4552aa653c93", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<net.core.ef.Models.Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\工作\C#\NetCore-ef\net.core.ef\net.core.ef\net.core.ef\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(92, 134, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>书名</th>\r\n        <th>内容</th>\r\n        <th>发布时间</th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 15 "D:\工作\C#\NetCore-ef\net.core.ef\net.core.ef\net.core.ef\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(267, 36, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(304, 41, false);
#line 19 "D:\工作\C#\NetCore-ef\net.core.ef\net.core.ef\net.core.ef\Views\Home\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.BookID));

#line default
#line hidden
            EndContext();
            BeginContext(345, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(389, 39, false);
#line 22 "D:\工作\C#\NetCore-ef\net.core.ef\net.core.ef\net.core.ef\Views\Home\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(428, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(472, 42, false);
#line 25 "D:\工作\C#\NetCore-ef\net.core.ef\net.core.ef\net.core.ef\Views\Home\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
            EndContext();
            BeginContext(514, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(558, 43, false);
#line 28 "D:\工作\C#\NetCore-ef\net.core.ef\net.core.ef\net.core.ef\Views\Home\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.DateTime));

#line default
#line hidden
            EndContext();
            BeginContext(601, 28, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 31 "D:\工作\C#\NetCore-ef\net.core.ef\net.core.ef\net.core.ef\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(636, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<net.core.ef.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
