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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Company/Delete.cshtml")]
    public partial class _Views_Company_Delete_cshtml : System.Web.Mvc.WebViewPage<Advertise.ViewModel.Models.Companies.CompanyDeleteViewModel>
    {
        public _Views_Company_Delete_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Company\Delete.cshtml"
  
    ViewBag.Title = "Delete";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n   " +
" <h4>CompanyDeleteViewModel</h4>\r\n    <hr />\r\n    <dl");

WriteLiteral(" class=\"dl-horizontal\"");

WriteLiteral(">\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 15 "..\..\Views\Company\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Code));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 19 "..\..\Views\Company\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Code));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 23 "..\..\Views\Company\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BrandName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 27 "..\..\Views\Company\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BrandName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 31 "..\..\Views\Company\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 35 "..\..\Views\Company\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 39 "..\..\Views\Company\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LogoFileName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 43 "..\..\Views\Company\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LogoFileName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 47 "..\..\Views\Company\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BackgroundFileName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 51 "..\..\Views\Company\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BackgroundFileName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 55 "..\..\Views\Company\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 59 "..\..\Views\Company\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 63 "..\..\Views\Company\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MobileNumber));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 67 "..\..\Views\Company\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MobileNumber));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 71 "..\..\Views\Company\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 75 "..\..\Views\Company\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 79 "..\..\Views\Company\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.WebSite));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 83 "..\..\Views\Company\Delete.cshtml"
       Write(Html.DisplayFor(model => model.WebSite));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 87 "..\..\Views\Company\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeCount));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 91 "..\..\Views\Company\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeCount));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 95 "..\..\Views\Company\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EstablishedOn));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 99 "..\..\Views\Company\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EstablishedOn));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n");

            
            #line 104 "..\..\Views\Company\Delete.cshtml"
    
            
            #line default
            #line hidden
            
            #line 104 "..\..\Views\Company\Delete.cshtml"
     using (Html.BeginForm()) {
        
            
            #line default
            #line hidden
            
            #line 105 "..\..\Views\Company\Delete.cshtml"
   Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 105 "..\..\Views\Company\Delete.cshtml"
                                


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"form-actions no-color\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Delete\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" /> |\r\n");

WriteLiteral("            ");

            
            #line 109 "..\..\Views\Company\Delete.cshtml"
       Write(Html.ActionLink("Back to List", "Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n");

            
            #line 111 "..\..\Views\Company\Delete.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591