#pragma checksum "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Task\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41c207b41e0b04b7838b8d1fea3b649666f86e10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Index), @"mvc.1.0.view", @"/Views/Task/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/Index.cshtml", typeof(AspNetCore.Views_Task_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41c207b41e0b04b7838b8d1fea3b649666f86e10", @"/Views/Task/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9352de2b183c6a4dac5a668ac59a4444d04ee22", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeManager.Models.TaskModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Task\Index.cshtml"
  
    ViewData["Title"] = "Task List";

#line default
#line hidden
            BeginContext(99, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(104, 17, false);
#line 5 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Task\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(121, 905, true);
            WriteLiteral(@"</h2>


<script type=""text/javascript"">

    ShowAdd = function () {
        window.open('/Task/Add', ""Add Task"", 'width=750px,height=600px,top=0,left=250');
        setTimeout(function () {
            window.location.reload(true);
        }, 3000)
    }


    ShowEdit = function (idValue) {
        window.open('/Task/Edit?id=' + idValue, ""Edit Task"", 'width=750px,height=600px,top=0,left=250');
        setTimeout(function () {
            window.location.reload(true);
        }, 3000)
    }

</script>

<input type=""button"" id=""btn_AddNew"" value=""Add Task"" onclick=""ShowAdd();"" />

<hr />
<table width=""100%"" border=""1"" class=""table"">
    <tr>
        <th>Task ID</th>
        <th>Title</th>
        <th>Description</th>
        <th>Status</th>
        <th>Start Date</th>
        <th>Create Date</th>
        <th>Complete Date</th>
        <th></th>
    </tr>

");
            EndContext();
#line 42 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Task\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(1067, 51, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n\r\n                 ");
            EndContext();
            BeginContext(1119, 11, false);
#line 47 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Task\Index.cshtml"
            Write(item.TaskId);

#line default
#line hidden
            EndContext();
            BeginContext(1130, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1188, 10, false);
#line 51 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Task\Index.cshtml"
           Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1198, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1254, 16, false);
#line 54 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Task\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1270, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n\r\n                ");
            EndContext();
            BeginContext(1328, 11, false);
#line 58 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Task\Index.cshtml"
           Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1339, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1397, 14, false);
#line 62 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Task\Index.cshtml"
           Write(item.StartDate);

#line default
#line hidden
            EndContext();
            BeginContext(1411, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1467, 16, false);
#line 65 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Task\Index.cshtml"
           Write(item.DateCreated);

#line default
#line hidden
            EndContext();
            BeginContext(1483, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1539, 18, false);
#line 68 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Task\Index.cshtml"
           Write(item.DateCompleted);

#line default
#line hidden
            EndContext();
            BeginContext(1557, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <input type=\"button\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1632, "\"", 1653, 2);
            WriteAttributeValue("", 1637, "btn_", 1637, 4, true);
#line 71 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Task\Index.cshtml"
WriteAttributeValue("", 1641, item.TaskId, 1641, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1654, 18, true);
            WriteLiteral(" value=\"Edit Task\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1672, "\"", 1705, 3);
            WriteAttributeValue("", 1682, "ShowEdit(", 1682, 9, true);
#line 71 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Task\Index.cshtml"
WriteAttributeValue("", 1691, item.TaskId, 1691, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1703, ");", 1703, 2, true);
            EndWriteAttribute();
            BeginContext(1706, 39, true);
            WriteLiteral(" />\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 74 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Task\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1752, 16, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeManager.Models.TaskModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
