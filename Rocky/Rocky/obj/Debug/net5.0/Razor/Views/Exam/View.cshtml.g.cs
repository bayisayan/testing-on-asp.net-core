#pragma checksum "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\Exam\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd7fca1f86ae483fae9d47c67cd3e4cc19355842"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exam_View), @"mvc.1.0.view", @"/Views/Exam/View.cshtml")]
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
#line 1 "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\_ViewImports.cshtml"
using Rocky;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\_ViewImports.cshtml"
using Rocky.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd7fca1f86ae483fae9d47c67cd3e4cc19355842", @"/Views/Exam/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b059994bcc2ab1f1ae0b9dc2d2eeafca20010c77", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Exam_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Exam>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\Exam\View.cshtml"
  
    ViewData["Title"] = "Upsert";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Upsert</h1>\r\n");
#nullable restore
#line 7 "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\Exam\View.cshtml"
 foreach (var item in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\Exam\View.cshtml"
Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\Exam\View.cshtml"
                 
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\Exam\View.cshtml"
Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Exam>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
