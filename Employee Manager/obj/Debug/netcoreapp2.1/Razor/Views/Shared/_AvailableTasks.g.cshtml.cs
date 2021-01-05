#pragma checksum "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Shared\_AvailableTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "443426843420ae820ee1be7e6b94d403654bcd2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AvailableTasks), @"mvc.1.0.view", @"/Views/Shared/_AvailableTasks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_AvailableTasks.cshtml", typeof(AspNetCore.Views_Shared__AvailableTasks))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"443426843420ae820ee1be7e6b94d403654bcd2d", @"/Views/Shared/_AvailableTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9352de2b183c6a4dac5a668ac59a4444d04ee22", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AvailableTasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeManager.Models.QueueModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Shared\_AvailableTasks.cshtml"
  
    ViewData["Title"] = "Task Queue";
    ViewData["Message"] = "Below is the tasks available for you, Click start task to begin the task.";

#line default
#line hidden
            BeginContext(205, 3776, true);
            WriteLiteral(@"
<style>

    #listtable {
        font-family: ""Trebuchet MS"", Arial, Helvetica, sans-serif;
        border-collapse: collapse;
        width: 100%;
    }

        #listtable td, #listtable th {
            border: 1px solid #ddd;
            padding: 8px;
        }

        #listtable tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        #listtable tr:hover {
            background-color: #ddd;
        }

        #listtable th {
            padding-top: 12px;
            padding-bottom: 12px;
            text-align: left;
            background-color: #4CAF50;
            color: white;
        }


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
        pad");
            WriteLiteral(@"ding: 14px 20px;
        margin: 8px 0;
        border: none;
        border-radius: 4px;
        cursor: pointer;
    }

        input[type=submit]:hover {
            background-color: #45a049;
        }



    .button {
        background-color: #4CAF50;
        color: white;
        padding: 14px 20px;
        margin: 8px 0;
        border: none;
        border-radius: 4px;
        cursor: pointer;
        width: inherit;
    }

    .button2 { /* Blue */
        background-color: #008CBA;
        color: white;
        padding: 14px 20px;
        margin: 8px 0;
        border: none;
        border-radius: 4px;
        cursor: pointer;
        width: inherit;
    }

    .button3 { /* Red */
        background-color: #f44336;
        color: white;
        padding: 14px 20px;
        margin: 8px 0;
        border: none;
        border-radius: 4px;
        cursor: pointer;
        width: inherit;
    }

    div {
        border-radius: 5px;
    }
</style>
<scri");
            WriteLiteral(@"pt type=""text/javascript"">



    ShowAdd = function () {

        var child = window.open('/Queue/Add', ""Add Task to Queue"", 'width=780px,height=380px,top=150,left=250');
        var timer = setInterval(checkChild, 500);

        function checkChild() {
            if (child.closed) {
                window.location.reload(true);
                clearInterval(timer);
            }
        }
    }


    ShowEdit = function (QueueId) {

        var child = window.open('/Queue/Edit?id=' + QueueId, ""Edit Queued Task"", 'width=780px,height=380px,top=150,left=250');
        var timer = setInterval(checkChild, 500);

        function checkChild() {
            if (child.closed) {
                window.location.reload(true);
                clearInterval(timer);
            }
        }
    }

    StartQueue = function (QueueId) {

        var child = window.open('/Queue/StartQueue?id=' + QueueId, ""Start Queue"", 'width=100px,height=100px,top=150,left=150');
        var timer = setInt");
            WriteLiteral(@"erval(checkChild, 500);

        function checkChild() {
            if (child.closed) {
                window.location.reload(true);
                clearInterval(timer);
            }
        }
    }

    DeleteQueue = function (QueueId) {

        var child = window.open('/Queue/Delete?id=' + QueueId, ""Edit Employee"", 'width=100px,height=100px,top=125,left=250');
        var timer = setInterval(checkChild, 500);

        function checkChild() {
            if (child.closed) {
                window.location.reload(true);
                clearInterval(timer);
            }
        }
    }



</script>


<table width=""100%"">
    <tr>
        <td>
            <h3>");
            EndContext();
            BeginContext(3982, 17, false);
#line 166 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Shared\_AvailableTasks.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(3999, 27, true);
            WriteLiteral("</h3>\r\n            <strong>");
            EndContext();
            BeginContext(4027, 19, false);
#line 167 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Shared\_AvailableTasks.cshtml"
               Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(4046, 310, true);
            WriteLiteral(@"</strong>
            <small>When you stop a task it will be available moved to the active queue.</small>
        </td>
        <td align=""right""></td>
    </tr>
</table>
<hr />
<table width=""100%"" border=""0"" id=""listtable"">
    <tr>
        <th>Task Description</th>
        <th></th>
    </tr>

");
            EndContext();
#line 180 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Shared\_AvailableTasks.cshtml"
     foreach (var item in Model)
    {



#line default
#line hidden
            BeginContext(4401, 7, true);
            WriteLiteral("    <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4408, "\"", 4429, 2);
            WriteAttributeValue("", 4413, "row_", 4413, 4, true);
#line 184 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Shared\_AvailableTasks.cshtml"
WriteAttributeValue("", 4417, item.TaskId, 4417, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4430, 37, true);
            WriteLiteral(">\r\n        <td>\r\n            <Strong>");
            EndContext();
            BeginContext(4468, 15, false);
#line 186 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Shared\_AvailableTasks.cshtml"
               Write(item.Task.Title);

#line default
#line hidden
            EndContext();
            BeginContext(4483, 29, true);
            WriteLiteral("</Strong><br />\r\n            ");
            EndContext();
            BeginContext(4513, 21, false);
#line 187 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Shared\_AvailableTasks.cshtml"
       Write(item.Task.Description);

#line default
#line hidden
            EndContext();
            BeginContext(4534, 36, true);
            WriteLiteral("<br />\r\n            <small>Task ID: ");
            EndContext();
            BeginContext(4571, 16, false);
#line 188 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Shared\_AvailableTasks.cshtml"
                       Write(item.Task.TaskId);

#line default
#line hidden
            EndContext();
            BeginContext(4587, 42, true);
            WriteLiteral("</small> - \r\n            <small>Employee: ");
            EndContext();
            BeginContext(4630, 22, false);
#line 189 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Shared\_AvailableTasks.cshtml"
                        Write(item.Employee.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(4652, 88, true);
            WriteLiteral("</small>\r\n        </td>\r\n\r\n        <td>\r\n            <input type=\"button\" Class=\"button\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4740, "\"", 4765, 2);
            WriteAttributeValue("", 4745, "btnsta_", 4745, 7, true);
#line 193 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Shared\_AvailableTasks.cshtml"
WriteAttributeValue("", 4752, item.QueueId, 4752, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 4766, "\"", 4793, 2);
            WriteAttributeValue("", 4773, "btnsta_", 4773, 7, true);
#line 193 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Shared\_AvailableTasks.cshtml"
WriteAttributeValue("", 4780, item.QueueId, 4780, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4794, 19, true);
            WriteLiteral(" value=\"Start Task\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4813, "\"", 4849, 3);
            WriteAttributeValue("", 4823, "StartQueue(", 4823, 11, true);
#line 193 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Shared\_AvailableTasks.cshtml"
WriteAttributeValue("", 4834, item.QueueId, 4834, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 4847, ");", 4847, 2, true);
            EndWriteAttribute();
            BeginContext(4850, 33, true);
            WriteLiteral(" />\r\n\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 197 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Shared\_AvailableTasks.cshtml"
    }

#line default
#line hidden
            BeginContext(4890, 16, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeManager.Models.QueueModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591