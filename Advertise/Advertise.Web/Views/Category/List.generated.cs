﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Advertise.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Category/List.cshtml")]
    public partial class _Views_Category_List_cshtml : System.Web.Mvc.WebViewPage<IEnumerable<Advertise.ViewModel.Models.Categories.Category.CategoryListViewModel>>
    {
        public _Views_Category_List_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

WriteLiteral("\n");

            
            #line 25 "..\..\Views\Category\List.cshtml"
  
    ViewBag.Title = "List";


            
            #line default
            #line hidden
WriteLiteral("\n\n<h2>List</h2>\n\n\n<p>\n");

WriteLiteral("    ");

            
            #line 34 "..\..\Views\Category\List.cshtml"
Write(Html.ActionLink("ایجاد جدید", "Create"));

            
            #line default
            #line hidden
WriteLiteral("\n</p>\n<table");

WriteLiteral(" class=\"table\"");

WriteLiteral(">\n    <tr>\n\n\n        <th>\n");

WriteLiteral("            ");

            
            #line 41 "..\..\Views\Category\List.cshtml"
       Write(Html.DisplayNameFor(model => model.Code));

            
            #line default
            #line hidden
WriteLiteral("\n        </th>\n\n\n        <th>\n");

WriteLiteral("            ");

            
            #line 46 "..\..\Views\Category\List.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

            
            #line default
            #line hidden
WriteLiteral("\n        </th>\n\n\n        <th>\n");

WriteLiteral("            ");

            
            #line 51 "..\..\Views\Category\List.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

            
            #line default
            #line hidden
WriteLiteral("\n        </th>\n\n\n        <th>\n");

WriteLiteral("            ");

            
            #line 56 "..\..\Views\Category\List.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageFileName));

            
            #line default
            #line hidden
WriteLiteral("\n        </th>\n\n\n        <th>\n");

WriteLiteral("            ");

            
            #line 61 "..\..\Views\Category\List.cshtml"
       Write(Html.DisplayNameFor(model => model.ParentPath));

            
            #line default
            #line hidden
WriteLiteral("\n        </th>\n\n\n        <th>\n");

WriteLiteral("            ");

            
            #line 66 "..\..\Views\Category\List.cshtml"
       Write(Html.DisplayNameFor(model => model.IsActive));

            
            #line default
            #line hidden
WriteLiteral("\n        </th>\n\n        <th></th>\n    </tr>\n\n");

            
            #line 72 "..\..\Views\Category\List.cshtml"
 foreach (var item in Model) {

            
            #line default
            #line hidden
WriteLiteral("    <tr>\n\n\n        <td>\n");

WriteLiteral("            ");

            
            #line 77 "..\..\Views\Category\List.cshtml"
       Write(Html.DisplayFor(modelItem => item.Code));

            
            #line default
            #line hidden
WriteLiteral("\n        </td>\n\n\n        <td>\n");

WriteLiteral("            ");

            
            #line 82 "..\..\Views\Category\List.cshtml"
       Write(Html.DisplayFor(modelItem => item.Title));

            
            #line default
            #line hidden
WriteLiteral("\n        </td>\n\n\n        <td>\n");

WriteLiteral("            ");

            
            #line 87 "..\..\Views\Category\List.cshtml"
       Write(Html.DisplayFor(modelItem => item.Description));

            
            #line default
            #line hidden
WriteLiteral("\n        </td>\n\n\n        <td>\n");

WriteLiteral("            ");

            
            #line 92 "..\..\Views\Category\List.cshtml"
       Write(Html.DisplayFor(modelItem => item.ImageFileName));

            
            #line default
            #line hidden
WriteLiteral("\n        </td>\n\n\n        <td>\n");

WriteLiteral("            ");

            
            #line 97 "..\..\Views\Category\List.cshtml"
       Write(Html.DisplayFor(modelItem => item.ParentPath));

            
            #line default
            #line hidden
WriteLiteral("\n        </td>\n\n\n        <td>\n");

WriteLiteral("            ");

            
            #line 102 "..\..\Views\Category\List.cshtml"
       Write(Html.DisplayFor(modelItem => item.IsActive));

            
            #line default
            #line hidden
WriteLiteral("\n        </td>\n\n        <td>\n");

WriteLiteral("            ");

            
            #line 106 "..\..\Views\Category\List.cshtml"
       Write(Html.ActionLink("ویرایش", "Edit", new { id=item.Id }));

            
            #line default
            #line hidden
WriteLiteral(" |\n");

WriteLiteral("            ");

            
            #line 107 "..\..\Views\Category\List.cshtml"
       Write(Html.ActionLink("جزییات", "Details", new { id=item.Id }));

            
            #line default
            #line hidden
WriteLiteral(" |\n");

WriteLiteral("            ");

            
            #line 108 "..\..\Views\Category\List.cshtml"
       Write(Html.ActionLink("حذف", "Delete", new { id=item.Id }));

            
            #line default
            #line hidden
WriteLiteral("\n        </td>\n\n    </tr>\n");

            
            #line 112 "..\..\Views\Category\List.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\n</table>\n\n\n\n");

        }
    }
}
#pragma warning restore 1591