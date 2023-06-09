#pragma checksum "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\Quez\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d5dc668a6b89d26908d7b0c2db0413b90cf5a17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quez_Index), @"mvc.1.0.view", @"/Views/Quez/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d5dc668a6b89d26908d7b0c2db0413b90cf5a17", @"/Views/Quez/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b059994bcc2ab1f1ae0b9dc2d2eeafca20010c77", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Quez_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Rocky.Models.Quez>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\Quez\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n\r\n        function CheckAnswer() {\r\n            var myArray = [];\r\n");
#nullable restore
#line 13 "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\Quez\Index.cshtml"
         foreach (var d in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                WriteLiteral("myArray.push(\"");
#nullable restore
#line 15 "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\Quez\Index.cshtml"
                       Write(d.QuestionNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n");
#nullable restore
#line 16 "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\Quez\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"         
            }           for (var i = 0; i < myArray.length; i++) {
                var right = $(""input[type='hidden'][name="" + myArray[i] + ""]"").val();
                $(""input[type='radio'][name="" + myArray[i] + ""]"").parent().removeClass(""right"");
                $(""input[type='radio'][name="" + myArray[i] + ""]"").parent().removeClass(""wrong"");
                $(""input[type='radio'][name="" + myArray[i] + ""]"").each(function () {
                    if ($(this).is("":checked"")) {
                        if ($(this).val() == right) {
                            $(this).parent().addClass(""right"")
                        } else {
                            $(this).parent().addClass(""wrong"");
                        }
                    }
                });

        }
    </script>

");
            }
            );
            WriteLiteral("\r\n    <style>\r\n        .right {\r\n            background-color: green;\r\n        }\r\n\r\n        .wrong {\r\n            background-color: red;\r\n        }\r\n    </style>\r\n\r\n\r\n    <p>Select an answer: </p>\r\n\r\n");
#nullable restore
#line 50 "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\Quez\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <label>Question ");
#nullable restore
#line 53 "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\Quez\Index.cshtml"
                   Write(item.QuestionNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" :</label>\r\n        <div class=\"col-md-10\">\r\n");
#nullable restore
#line 55 "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\Quez\Index.cshtml"
             foreach (var option in item.Options)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"radio\"");
            BeginWriteAttribute("value", " value=\"", 1605, "\"", 1626, 1);
#nullable restore
#line 57 "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\Quez\Index.cshtml"
WriteAttributeValue("", 1613, option.Index, 1613, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 1627, "\"", 1654, 1);
#nullable restore
#line 57 "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\Quez\Index.cshtml"
WriteAttributeValue("", 1634, item.QuestionNumber, 1634, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /> ");
#nullable restore
#line 57 "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\Quez\Index.cshtml"
                                                                                    Write(option.Option);

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\Quez\Index.cshtml"
                                                                                                       
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1722, "\"", 1747, 1);
#nullable restore
#line 59 "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\Quez\Index.cshtml"
WriteAttributeValue("", 1730, item.RightAnswer, 1730, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 1748, "\"", 1775, 1);
#nullable restore
#line 59 "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\Quez\Index.cshtml"
WriteAttributeValue("", 1755, item.QuestionNumber, 1755, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 62 "D:\Bayys\source\repos\Rocky\Rocky\Rocky\Views\Quez\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<input type=\"button\" value=\"Check\" onclick=\"CheckAnswer()\" />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Rocky.Models.Quez>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
