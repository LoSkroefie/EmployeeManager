#pragma checksum "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Access\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "699feda3055c1626ebfdaf14945e2fcd691f83e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Access_Index), @"mvc.1.0.view", @"/Views/Access/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Access/Index.cshtml", typeof(AspNetCore.Views_Access_Index))]
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
#line 1 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\_ViewImports.cshtml"
using EmployeeManager;

#line default
#line hidden
#line 2 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\_ViewImports.cshtml"
using EmployeeManager.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"699feda3055c1626ebfdaf14945e2fcd691f83e5", @"/Views/Access/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9352de2b183c6a4dac5a668ac59a4444d04ee22", @"/Views/_ViewImports.cshtml")]
    public class Views_Access_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeManager.Models.AccessModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Access\Index.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(84, 863, true);
            WriteLiteral(@"
<style>



    input[type=text], select {
        width: 100%;
        padding: 12px 20px;
        margin: 8px 0;
        display: inline-block;
        border: 1px solid #ccc;
        border-radius: 4px;
        box-sizing: border-box;
    }

    input[type=password], select {
        width: 100%;
        padding: 12px 20px;
        margin: 8px 0;
        display: inline-block;
        border: 1px solid #ccc;
        border-radius: 4px;
        box-sizing: border-box;
    }

    input[type=submit] {
        width: 100%;
        background-color: #4CAF50;
        color: white;
        padding: 14px 20px;
        margin: 8px 0;
        border: none;
        border-radius: 4px;
        cursor: pointer;
    }

        input[type=submit]:hover {
            background-color: #45a049;
        }


</style>


<h2>");
            EndContext();
            BeginContext(948, 17, false);
#line 49 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Access\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(965, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(977, 19, false);
#line 50 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Access\Index.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(996, 11, true);
            WriteLiteral("</h3>\r\n<h3>");
            EndContext();
            BeginContext(1008, 14, false);
#line 51 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Access\Index.cshtml"
Write(ViewData["ID"]);

#line default
#line hidden
            EndContext();
            BeginContext(1022, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
#line 53 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Access\Index.cshtml"
 using (Html.BeginForm("Index", "Access", FormMethod.Post))
{



#line default
#line hidden
            BeginContext(1099, 188, true);
            WriteLiteral("    <div style=\"margin: 0 auto; width:50%;\">\r\n        <table width=\"100%\" cellpadding=\"2\" cellspacing=\"3\">\r\n            <tr>\r\n                <td colspan=\"2\">\r\n                    <strong>");
            EndContext();
            BeginContext(1288, 30, false);
#line 61 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Access\Index.cshtml"
                       Write(Html.LabelFor(m => m.Username));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 37, true);
            WriteLiteral("</strong><br />\r\n                    ");
            EndContext();
            BeginContext(1356, 111, false);
#line 62 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Access\Index.cshtml"
               Write(Html.TextBoxFor(m => m.Username, new { htmlAttributes = new { @class = "form-control"
                    } }));

#line default
#line hidden
            EndContext();
            BeginContext(1467, 124, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">\r\n                    <strong>");
            EndContext();
            BeginContext(1592, 30, false);
#line 68 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Access\Index.cshtml"
                       Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(1622, 37, true);
            WriteLiteral("</strong><br />\r\n                    ");
            EndContext();
            BeginContext(1660, 112, false);
#line 69 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Access\Index.cshtml"
               Write(Html.PasswordFor(m => m.Password, new { htmlAttributes = new { @class =
                    "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1772, 168, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n\r\n        </table>\r\n\r\n        <p>\r\n            <input type=\"submit\" name=\"Submit\" value=\"Login\">\r\n        </p>\r\n    </div>\r\n");
            EndContext();
#line 80 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Access\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1943, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeManager.Models.AccessModel> Html { get; private set; }
    }
}
#pragma warning restore 1591