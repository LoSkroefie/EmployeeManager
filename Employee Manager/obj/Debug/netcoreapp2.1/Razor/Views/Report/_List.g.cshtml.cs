#pragma checksum "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Report\_List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9be3e0a8e6447a73c60bf4d4318e42ef4879d9e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report__List), @"mvc.1.0.view", @"/Views/Report/_List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Report/_List.cshtml", typeof(AspNetCore.Views_Report__List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9be3e0a8e6447a73c60bf4d4318e42ef4879d9e2", @"/Views/Report/_List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9352de2b183c6a4dac5a668ac59a4444d04ee22", @"/Views/_ViewImports.cshtml")]
    public class Views_Report__List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeManager.Models.ReportModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Report\_List.cshtml"
  
    ViewData["Title"] = "Hours Worked Report";

#line default
#line hidden
            BeginContext(100, 64, true);
            WriteLiteral("\r\n<table width=\"100%\">\r\n    <tr>\r\n        <td>\r\n            <h3>");
            EndContext();
            BeginContext(165, 17, false);
#line 10 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Report\_List.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(182, 27, true);
            WriteLiteral("</h3>\r\n            <strong>");
            EndContext();
            BeginContext(210, 19, false);
#line 11 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Report\_List.cshtml"
               Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(229, 911, true);
            WriteLiteral(@"</strong>
        </td>
        <td></td>
    </tr>
</table>
<hr />

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
");
            EndContext();
#line 58 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Report\_List.cshtml"
 using (Html.BeginForm("RunReport", "Report", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(1208, 54, true);
            WriteLiteral("<table width=\"100%\" cellpadding=\"2\" cellspacing=\"3\">\r\n");
            EndContext();
#line 61 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Report\_List.cshtml"
     if (Model.IsAdmin)
    {

#line default
#line hidden
            BeginContext(1294, 109, true);
            WriteLiteral("        <tr>\r\n            <td colspan=\"2\">\r\n                <strong>Employee</strong><br />\r\n                ");
            EndContext();
            BeginContext(1404, 116, false);
#line 66 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Report\_List.cshtml"
           Write(Html.DropDownListFor(m => m.EmployeeId, new SelectList(Model.Employees, "EmployeeId", "Fullname", Model.EmployeeId)));

#line default
#line hidden
            EndContext();
            BeginContext(1520, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 69 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Report\_List.cshtml"
    }

#line default
#line hidden
            BeginContext(1563, 89, true);
            WriteLiteral("\r\n\r\n    <tr>\r\n        <td>\r\n            <strong>Start Date</strong><br />\r\n\r\n            ");
            EndContext();
            BeginContext(1653, 120, false);
#line 76 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Report\_List.cshtml"
       Write(Html.EditorFor(m => m.ReportStartDate, new { htmlAttributes = new { @class = "form-control datepicker"
            } }));

#line default
#line hidden
            EndContext();
            BeginContext(1773, 90, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            <strong>End Date</strong><br />\r\n\r\n            ");
            EndContext();
            BeginContext(1864, 118, false);
#line 82 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Report\_List.cshtml"
       Write(Html.EditorFor(m => m.ReportEndDate, new { htmlAttributes = new { @class = "form-control datepicker"
            } }));

#line default
#line hidden
            EndContext();
            BeginContext(1982, 40, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n\r\n</table>\r\n");
            EndContext();
            BeginContext(2024, 76, true);
            WriteLiteral("<p>\r\n    <input type=\"submit\" name=\"Submit\" value=\"Generate Report\">\r\n</p>\r\n");
            EndContext();
#line 92 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Report\_List.cshtml"

}

#line default
#line hidden
            BeginContext(2105, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeManager.Models.ReportModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
