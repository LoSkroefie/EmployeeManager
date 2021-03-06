#pragma checksum "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccfc8001f4eb266c8315e6d5fe9c9f8ee2eac20a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QueueRoll_Index), @"mvc.1.0.view", @"/Views/QueueRoll/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/QueueRoll/Index.cshtml", typeof(AspNetCore.Views_QueueRoll_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccfc8001f4eb266c8315e6d5fe9c9f8ee2eac20a", @"/Views/QueueRoll/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9352de2b183c6a4dac5a668ac59a4444d04ee22", @"/Views/_ViewImports.cshtml")]
    public class Views_QueueRoll_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeManager.Models.QueueRollModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\Index.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(100, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(105, 17, false);
#line 5 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(122, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(134, 19, false);
#line 6 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\Index.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(153, 1294, true);
            WriteLiteral(@"</h3>

<script type=""text/javascript"">



    ShowAdd = function () {
        
        var child = window.open('/Queue/Add', ""Add Queue"", 'width=780px,height=600px,top=0,left=250');
        var timer = setInterval(checkChild, 500);

        function checkChild() {
            if (child.closed) {
                window.location.reload(true);
                clearInterval(timer);
            }
        }
    }


    ShowEdit = function (QueueId) {
       
        var child = window.open('/Queue/Edit?id=' + QueueId, ""Edit Queue"", 'width=780px,height=600px,top=0,left=250');
        var timer = setInterval(checkChild, 500);

        function checkChild() {
            if (child.closed) {
                window.location.reload(true);
                clearInterval(timer);
            }
        }
    }

 

    StopItem = function (RollId) {
        $.post(""QueueRoll/StopQueue"", { id: RollId }, function (data) {
            $(""#row_"" + RollId).hide();
        });
    }

</script");
            WriteLiteral(@">

<input type=""button"" id=""btn_AddNew"" value=""Add Queue"" onclick=""ShowAdd();"" />
<hr />

<table width=""100%"" border=""1"" class=""table"">
    <tr>
        <th>Queue ID</th>
        <th>Assigned Employee</th>
        <th>Task</th>
        <th></th>
    </tr>

");
            EndContext();
#line 60 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\Index.cshtml"
     foreach (var item in Model)
    {

        

#line default
#line hidden
#line 63 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\Index.cshtml"
         if (item.StopDate == DateTime.MinValue)
        {

#line default
#line hidden
            BeginContext(1551, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1566, "\"", 1587, 2);
            WriteAttributeValue("", 1571, "row_", 1571, 4, true);
#line 65 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\Index.cshtml"
WriteAttributeValue("", 1575, item.RollId, 1575, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1588, 45, true);
            WriteLiteral(">\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1634, 11, false);
#line 67 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\Index.cshtml"
               Write(item.RollId);

#line default
#line hidden
            EndContext();
            BeginContext(1645, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1713, 12, false);
#line 70 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\Index.cshtml"
               Write(item.QueueId);

#line default
#line hidden
            EndContext();
            BeginContext(1725, 75, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <strong>");
            EndContext();
            BeginContext(1801, 18, false);
#line 73 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\Index.cshtml"
                       Write(item.Employee.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1819, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1821, 22, false);
#line 73 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\Index.cshtml"
                                           Write(item.Employee.Lastname);

#line default
#line hidden
            EndContext();
            BeginContext(1843, 77, true);
            WriteLiteral("</strong>\r\n                </td>\r\n                <td>\r\n                    (");
            EndContext();
            BeginContext(1921, 16, false);
#line 76 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\Index.cshtml"
                Write(item.Task.TaskId);

#line default
#line hidden
            EndContext();
            BeginContext(1937, 10, true);
            WriteLiteral(") <strong>");
            EndContext();
            BeginContext(1948, 15, false);
#line 76 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\Index.cshtml"
                                           Write(item.Task.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1963, 38, true);
            WriteLiteral("</strong> <br />\r\n                    ");
            EndContext();
            BeginContext(2002, 21, false);
#line 77 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\Index.cshtml"
               Write(item.Task.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2023, 89, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    <input type=\"button\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2112, "\"", 2136, 2);
            WriteAttributeValue("", 2117, "btnsto_", 2117, 7, true);
#line 81 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\Index.cshtml"
WriteAttributeValue("", 2124, item.RollId, 2124, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 2137, "\"", 2163, 2);
            WriteAttributeValue("", 2144, "btnsto_", 2144, 7, true);
#line 81 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\Index.cshtml"
WriteAttributeValue("", 2151, item.RollId, 2151, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2164, 18, true);
            WriteLiteral(" value=\"Stop Task\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2182, "\"", 2215, 3);
            WriteAttributeValue("", 2192, "StopItem(", 2192, 9, true);
#line 81 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\Index.cshtml"
WriteAttributeValue("", 2201, item.RollId, 2201, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 2213, ");", 2213, 2, true);
            EndWriteAttribute();
            BeginContext(2216, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(2345, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 85 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\Index.cshtml"
        }

#line default
#line hidden
#line 85 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\QueueRoll\Index.cshtml"
         


    }

#line default
#line hidden
            BeginContext(2409, 16, true);
            WriteLiteral("\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeManager.Models.QueueRollModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
