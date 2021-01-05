#pragma checksum "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3f193e2ed36b2d7967cdf661df6a04f14d885ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Queue__List), @"mvc.1.0.view", @"/Views/Queue/_List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Queue/_List.cshtml", typeof(AspNetCore.Views_Queue__List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3f193e2ed36b2d7967cdf661df6a04f14d885ef", @"/Views/Queue/_List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9352de2b183c6a4dac5a668ac59a4444d04ee22", @"/Views/_ViewImports.cshtml")]
    public class Views_Queue__List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeManager.Models.QueueModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml"
  
    ViewData["Title"] = "Manage Task Queue";

#line default
#line hidden
            BeginContext(108, 4480, true);
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

    .button4 { /* Orange */
        background-color: darkora");
            WriteLiteral(@"nge;
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
<script type=""text/javascript"">



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
                window.location.reload(true);");
            WriteLiteral(@"
                clearInterval(timer);
            }
        }
    }

    StartQueue = function (QueueId) {
       
        var child = window.open('/Queue/StartQueue?id=' + QueueId, ""Edit Queue"", 'width=100px,height=100px,top=150,left=150');
        var timer = setInterval(checkChild, 500);

        function checkChild() {
            if (child.closed) {
                window.location.reload(true);
                clearInterval(timer);
            }
        }
    }

    CompleteItem = function (QueueId) {


        var child = window.open('/Queue/CompleteQueue?id=' + QueueId, ""Complete Queued Task"", 'width=100px,height=100px,top=150,left=150');
        var timer = setInterval(checkChild, 500);

        function checkChild() {
            if (child.closed) {
                window.location.reload(true);
                clearInterval(timer);
            }
        }
    }

    DeleteQueue = function (QueueId) {

        var child = window.open('/Queue/Delete?id=' + QueueId, """);
            WriteLiteral(@"Edit Employee"", 'width=100px,height=100px,top=125,left=250');
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
            BeginContext(4589, 17, false);
#line 190 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(4606, 27, true);
            WriteLiteral("</h3>\r\n            <strong>");
            EndContext();
            BeginContext(4634, 19, false);
#line 191 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml"
               Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(4653, 365, true);
            WriteLiteral(@"</strong>
        </td>
        <td align=""right""><input type=""button"" class=""button"" id=""btn_AddNew"" value=""Add Task to Queue"" onclick=""ShowAdd();"" /></td>
    </tr>
</table>
<hr />
<table width=""100%"" border=""1"" id=""listtable"">
    <tr>
        <th>Queue ID</th>
        <th>Assigned Employee</th>
        <th>Task</th>
        <th></th>
    </tr>

");
            EndContext();
#line 205 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml"
     foreach (var item in Model)
    {



#line default
#line hidden
            BeginContext(5063, 11, true);
            WriteLiteral("        <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5074, "\"", 5096, 2);
            WriteAttributeValue("", 5079, "row_", 5079, 4, true);
#line 209 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml"
WriteAttributeValue("", 5083, item.QueueId, 5083, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5097, 39, true);
            WriteLiteral(">\r\n            <td>\r\n\r\n                ");
            EndContext();
            BeginContext(5137, 12, false);
#line 212 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml"
           Write(item.QueueId);

#line default
#line hidden
            EndContext();
            BeginContext(5149, 58, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                (");
            EndContext();
            BeginContext(5208, 24, false);
#line 216 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml"
            Write(item.Employee.EmployeeId);

#line default
#line hidden
            EndContext();
            BeginContext(5232, 2, true);
            WriteLiteral(") ");
            EndContext();
            BeginContext(5235, 22, false);
#line 216 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml"
                                       Write(item.Employee.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(5257, 56, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                (");
            EndContext();
            BeginContext(5314, 16, false);
#line 219 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml"
            Write(item.Task.TaskId);

#line default
#line hidden
            EndContext();
            BeginContext(5330, 2, true);
            WriteLiteral(") ");
            EndContext();
            BeginContext(5333, 15, false);
#line 219 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml"
                               Write(item.Task.Title);

#line default
#line hidden
            EndContext();
            BeginContext(5348, 25, true);
            WriteLiteral(" <br />\r\n                ");
            EndContext();
            BeginContext(5374, 21, false);
#line 220 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml"
           Write(item.Task.Description);

#line default
#line hidden
            EndContext();
            BeginContext(5395, 92, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                <input type=\"button\" Class=\"button\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5487, "\"", 5512, 2);
            WriteAttributeValue("", 5492, "btnsta_", 5492, 7, true);
#line 224 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml"
WriteAttributeValue("", 5499, item.QueueId, 5499, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 5513, "\"", 5540, 2);
            WriteAttributeValue("", 5520, "btnsta_", 5520, 7, true);
#line 224 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml"
WriteAttributeValue("", 5527, item.QueueId, 5527, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5541, 19, true);
            WriteLiteral(" value=\"Start Task\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5560, "\"", 5596, 3);
            WriteAttributeValue("", 5570, "StartQueue(", 5570, 11, true);
#line 224 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml"
WriteAttributeValue("", 5581, item.QueueId, 5581, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 5594, ");", 5594, 2, true);
            EndWriteAttribute();
            BeginContext(5597, 57, true);
            WriteLiteral(" />\r\n                <input type=\"button\" class=\"button4\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5654, "\"", 5679, 2);
            WriteAttributeValue("", 5659, "btncom_", 5659, 7, true);
#line 225 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml"
WriteAttributeValue("", 5666, item.QueueId, 5666, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 5680, "\"", 5707, 2);
            WriteAttributeValue("", 5687, "btncom_", 5687, 7, true);
#line 225 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml"
WriteAttributeValue("", 5694, item.QueueId, 5694, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5708, 17, true);
            WriteLiteral(" value=\"Complete\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5725, "\"", 5763, 3);
            WriteAttributeValue("", 5735, "CompleteItem(", 5735, 13, true);
#line 225 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml"
WriteAttributeValue("", 5748, item.QueueId, 5748, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 5761, ");", 5761, 2, true);
            EndWriteAttribute();
            BeginContext(5764, 57, true);
            WriteLiteral(" />\r\n                <input type=\"button\" class=\"button2\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5821, "\"", 5843, 2);
            WriteAttributeValue("", 5826, "btn_", 5826, 4, true);
#line 226 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml"
WriteAttributeValue("", 5830, item.QueueId, 5830, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5844, 13, true);
            WriteLiteral(" value=\"Edit\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5857, "\"", 5891, 3);
            WriteAttributeValue("", 5867, "ShowEdit(", 5867, 9, true);
#line 226 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml"
WriteAttributeValue("", 5876, item.QueueId, 5876, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 5889, ");", 5889, 2, true);
            EndWriteAttribute();
            BeginContext(5892, 57, true);
            WriteLiteral(" />\r\n                <input type=\"button\" class=\"button3\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5949, "\"", 5971, 2);
            WriteAttributeValue("", 5954, "btn_", 5954, 4, true);
#line 227 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml"
WriteAttributeValue("", 5958, item.QueueId, 5958, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5972, 15, true);
            WriteLiteral(" value=\"Delete\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5987, "\"", 6024, 3);
            WriteAttributeValue("", 5997, "DeleteQueue(", 5997, 12, true);
#line 227 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml"
WriteAttributeValue("", 6009, item.QueueId, 6009, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 6022, ");", 6022, 2, true);
            EndWriteAttribute();
            BeginContext(6025, 39, true);
            WriteLiteral(" />\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 230 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Queue\_List.cshtml"
    }

#line default
#line hidden
            BeginContext(6071, 16, true);
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
