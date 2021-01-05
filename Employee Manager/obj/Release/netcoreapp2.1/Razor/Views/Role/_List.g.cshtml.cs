#pragma checksum "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Role\_List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82f70dde99b8e8f789576c17bf1ae5a8c133e63e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role__List), @"mvc.1.0.view", @"/Views/Role/_List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Role/_List.cshtml", typeof(AspNetCore.Views_Role__List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82f70dde99b8e8f789576c17bf1ae5a8c133e63e", @"/Views/Role/_List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9352de2b183c6a4dac5a668ac59a4444d04ee22", @"/Views/_ViewImports.cshtml")]
    public class Views_Role__List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeManager.Models.RoleModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Role\_List.cshtml"
  
    ViewData["Title"] = "Manage Roles";

#line default
#line hidden
            BeginContext(102, 3342, true);
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
        p");
            WriteLiteral(@"adding: 14px 20px;
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
        background-color: red;
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
<script");
            WriteLiteral(@" type=""text/javascript"">

    CreateRole = function () {
        var child = window.open('/Role/Add', ""Create Role"", 'width=780px,height=380px,top=150,left=250');
        var timer = setInterval(checkChild, 500);

        function checkChild() {
            if (child.closed) {
                window.location.reload(true);
                clearInterval(timer);
            }
        }
    }


    EditRole = function (RoleId) {
        var child = window.open('/Role/Edit?id=' + RoleId, ""Edit Role"", 'width=780px,height=380px,top=150,left=250');
        var timer = setInterval(checkChild, 500);

        function checkChild() {
            if (child.closed) {
                window.location.reload(true);
                clearInterval(timer);
            }
        }
    }

    DeleteRole = function (RoleId) {

        var child = window.open('/Role/Delete?id=' + RoleId, ""Delete Role"", 'width=100px,height=100px,top=125,left=250');
        var timer = setInterval(checkChild, 500);

    ");
            WriteLiteral(@"    function checkChild() {
            if (child.closed) {
                window.location.reload(true);
                clearInterval(timer);
            }
        }
    }


</script>


<hr />
<table width=""100%"">
    <tr>
        <td>
            <h3>");
            EndContext();
            BeginContext(3445, 17, false);
#line 149 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Role\_List.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(3462, 27, true);
            WriteLiteral("</h3>\r\n            <strong>");
            EndContext();
            BeginContext(3490, 19, false);
#line 150 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Role\_List.cshtml"
               Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(3509, 354, true);
            WriteLiteral(@"</strong>
        </td>
        <td align=""right""><input type=""button"" class=""button"" id=""btn_AddNew"" value=""Add Role"" onclick=""CreateRole();"" /></td>
    </tr>
</table>
<hr />
<table width=""100%"" border=""0"" id=""listtable"">
    <tr>
        <th>Role ID</th>
        <th>Description</th>
        <th>Rate</th>

        <th></th>
    </tr>

");
            EndContext();
#line 165 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Role\_List.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(3904, 50, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n\r\n                ");
            EndContext();
            BeginContext(3955, 11, false);
#line 170 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Role\_List.cshtml"
           Write(item.RoleId);

#line default
#line hidden
            EndContext();
            BeginContext(3966, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4024, 16, false);
#line 174 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Role\_List.cshtml"
           Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(4040, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4096, 9, false);
#line 177 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Role\_List.cshtml"
           Write(item.Rate);

#line default
#line hidden
            EndContext();
            BeginContext(4105, 107, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td align=\"right\">\r\n                <input type=\"button\" class=\"button2\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4212, "\"", 4233, 2);
            WriteAttributeValue("", 4217, "btn_", 4217, 4, true);
#line 181 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Role\_List.cshtml"
WriteAttributeValue("", 4221, item.RoleId, 4221, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4234, 13, true);
            WriteLiteral(" value=\"Edit\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4247, "\"", 4280, 3);
            WriteAttributeValue("", 4257, "EditRole(", 4257, 9, true);
#line 181 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Role\_List.cshtml"
WriteAttributeValue("", 4266, item.RoleId, 4266, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 4278, ");", 4278, 2, true);
            EndWriteAttribute();
            BeginContext(4281, 57, true);
            WriteLiteral(" />\r\n                <input type=\"button\" class=\"button3\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4338, "\"", 4359, 2);
            WriteAttributeValue("", 4343, "btn_", 4343, 4, true);
#line 182 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Role\_List.cshtml"
WriteAttributeValue("", 4347, item.RoleId, 4347, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4360, 15, true);
            WriteLiteral(" value=\"Delete\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4375, "\"", 4410, 3);
            WriteAttributeValue("", 4385, "DeleteRole(", 4385, 11, true);
#line 182 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Role\_List.cshtml"
WriteAttributeValue("", 4396, item.RoleId, 4396, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 4408, ");", 4408, 2, true);
            EndWriteAttribute();
            BeginContext(4411, 39, true);
            WriteLiteral(" />\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 185 "C:\Users\jvrso\source\repos\Employee Manager\Employee Manager\Views\Role\_List.cshtml"
    }

#line default
#line hidden
            BeginContext(4457, 16, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeManager.Models.RoleModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
