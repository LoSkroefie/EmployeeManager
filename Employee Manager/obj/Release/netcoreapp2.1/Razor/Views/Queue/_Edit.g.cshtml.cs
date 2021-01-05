#pragma checksum "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54b360ebcfd1760ba2b8ead8f172e030c161b401"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Queue__Edit), @"mvc.1.0.view", @"/Views/Queue/_Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Queue/_Edit.cshtml", typeof(AspNetCore.Views_Queue__Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54b360ebcfd1760ba2b8ead8f172e030c161b401", @"/Views/Queue/_Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9352de2b183c6a4dac5a668ac59a4444d04ee22", @"/Views/_ViewImports.cshtml")]
    public class Views_Queue__Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeManager.Models.QueueModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_Edit.cshtml"
  
    ViewData["Title"] = "Edit Queued Task";

#line default
#line hidden
            BeginContext(94, 666, true);
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


</style>

<table width=""100%"">
    <tr>
        <td>
            <h3>");
            EndContext();
            BeginContext(761, 17, false);
#line 38 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_Edit.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(778, 27, true);
            WriteLiteral("</h3>\r\n            <strong>");
            EndContext();
            BeginContext(806, 19, false);
#line 39 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_Edit.cshtml"
               Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(825, 74, true);
            WriteLiteral("</strong>\r\n        </td>\r\n        <td></td>\r\n    </tr>\r\n</table>\r\n<hr />\r\n");
            EndContext();
#line 45 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_Edit.cshtml"
 using (Html.BeginForm("EditQueue", "Queue", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(971, 30, false);
#line 47 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_Edit.cshtml"
Write(Html.HiddenFor(m => m.QueueId));

#line default
#line hidden
            EndContext();
#line 47 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_Edit.cshtml"
                                   ;

#line default
#line hidden
            BeginContext(1004, 167, true);
            WriteLiteral("    <table width=\"100%\" cellpadding=\"2\" cellspacing=\"3\">\r\n        <tr>\r\n            <td colspan=\"2\">\r\n                <strong>Employee</strong><br />\r\n                ");
            EndContext();
            BeginContext(1172, 116, false);
#line 52 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_Edit.cshtml"
           Write(Html.DropDownListFor(m => m.EmployeeId, new SelectList(Model.Employees, "EmployeeId", "Fullname", Model.EmployeeId)));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 141, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\">\r\n                <strong>Task</strong><br />\r\n                ");
            EndContext();
            BeginContext(1430, 97, false);
#line 58 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_Edit.cshtml"
           Write(Html.DropDownListFor(m => m.TaskId, new SelectList(Model.Tasks, "TaskId", "Title", Model.TaskId)));

#line default
#line hidden
            EndContext();
            BeginContext(1527, 54, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n\r\n\r\n    </table>\r\n");
            EndContext();
            BeginContext(1583, 89, true);
            WriteLiteral("    <p>\r\n        <input type=\"submit\" name=\"Submit\" value=\"Save Queued Task\">\r\n    </p>\r\n");
            EndContext();
#line 68 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_Edit.cshtml"

}

#line default
#line hidden
            BeginContext(1677, 16, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeManager.Models.QueueModel> Html { get; private set; }
    }
}
#pragma warning restore 1591