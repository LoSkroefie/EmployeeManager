#pragma checksum "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85a8e683f7662584cbbaa250175456bcc02c0d81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Login.cshtml", typeof(AspNetCore.Views_Home_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85a8e683f7662584cbbaa250175456bcc02c0d81", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9352de2b183c6a4dac5a668ac59a4444d04ee22", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeManager.Models.AccessModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(84, 941, true);
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

    div {
        border-radius: 5px;
        background-color: #f2f2f2;
        padding: 20px;
    }
</style>
<script type=""text/javascript"">
    $(function () {
        $("".date-picker"").datepicker({
            dateFormat: 'dd-M-yy'
        });

    });

</script>
<table width=""100%"">
    <tr>
        <td>
            <h3>");
            EndContext();
            BeginContext(1026, 17, false);
#line 53 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Home\Login.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(1043, 27, true);
            WriteLiteral("</h3>\r\n            <strong>");
            EndContext();
            BeginContext(1071, 19, false);
#line 54 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Home\Login.cshtml"
               Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(1090, 74, true);
            WriteLiteral("</strong>\r\n        </td>\r\n        <td></td>\r\n    </tr>\r\n</table>\r\n<hr />\r\n");
            EndContext();
#line 60 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Home\Login.cshtml"
 using (Html.BeginForm("Login", "Home", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(1226, 167, true);
            WriteLiteral("<div style=\"margin: 0 auto; width:50%;\">\r\n    <table width=\"50%\" cellpadding=\"2\" cellspacing=\"3\">\r\n        <tr>\r\n            <td colspan=\"2\">\r\n                <strong>");
            EndContext();
            BeginContext(1394, 30, false);
#line 66 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Home\Login.cshtml"
                   Write(Html.LabelFor(m => m.Username));

#line default
#line hidden
            EndContext();
            BeginContext(1424, 33, true);
            WriteLiteral("</strong><br />\r\n                ");
            EndContext();
            BeginContext(1458, 107, false);
#line 67 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Home\Login.cshtml"
           Write(Html.TextBoxFor(m => m.Username, new { htmlAttributes = new { @class = "form-control"
                } }));

#line default
#line hidden
            EndContext();
            BeginContext(1565, 145, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\">\r\n                <strong>Password</strong><br />\r\n                ");
            EndContext();
            BeginContext(1711, 108, false);
#line 74 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Home\Login.cshtml"
           Write(Html.PasswordFor(m => m.Password, new { htmlAttributes = new { @class =
                "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1819, 140, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n\r\n    </table>\r\n\r\n    <p>\r\n        <input type=\"submit\" name=\"Submit\" value=\"Login\">\r\n    </p>\r\n</div>\r\n");
            EndContext();
#line 85 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Home\Login.cshtml"

}

#line default
#line hidden
            BeginContext(1964, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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