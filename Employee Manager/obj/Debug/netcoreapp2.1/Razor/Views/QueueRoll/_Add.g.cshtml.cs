#pragma checksum "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\_Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed45c8ac2720335fa58a8d581f2d8a288c150d88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QueueRoll__Add), @"mvc.1.0.view", @"/Views/QueueRoll/_Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/QueueRoll/_Add.cshtml", typeof(AspNetCore.Views_QueueRoll__Add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed45c8ac2720335fa58a8d581f2d8a288c150d88", @"/Views/QueueRoll/_Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9352de2b183c6a4dac5a668ac59a4444d04ee22", @"/Views/_ViewImports.cshtml")]
    public class Views_QueueRoll__Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeManager.Models.QueueRollModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\_Add.cshtml"
  
    ViewData["Title"] = "Add Queue";

#line default
#line hidden
            BeginContext(91, 777, true);
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

<table width=""100%"">
    <tr>
        <td>
            <h3>");
            EndContext();
            BeginContext(869, 17, false);
#line 45 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\_Add.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(886, 27, true);
            WriteLiteral("</h3>\r\n            <strong>");
            EndContext();
            BeginContext(914, 19, false);
#line 46 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\_Add.cshtml"
               Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(933, 76, true);
            WriteLiteral("</strong>\r\n        </td>\r\n        <td></td>\r\n    </tr>\r\n</table>\r\n<hr />\r\n\r\n");
            EndContext();
#line 53 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\_Add.cshtml"
 using (Html.BeginForm("AddQueue", "Queue", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(1075, 295, true);
            WriteLiteral(@"<table width=""100%"" cellpadding=""2"" cellspacing=""3"">
    <tr>
        <td colspan=""2"">
            <strong>Employee</strong><br />
 
        </td>
    </tr>
    <tr>
        <td colspan=""2"">
            <strong>Task</strong><br />
          
        </td>
    </tr>
    
</table>
");
            EndContext();
            BeginContext(1372, 91, true);
            WriteLiteral("    <p>\r\n        <input type=\"submit\" name=\"Submit\" value=\"Save Task to Queue\">\r\n    </p>\r\n");
            EndContext();
#line 74 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\_Add.cshtml"

}

#line default
#line hidden
            BeginContext(1468, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeManager.Models.QueueRollModel> Html { get; private set; }
    }
}
#pragma warning restore 1591