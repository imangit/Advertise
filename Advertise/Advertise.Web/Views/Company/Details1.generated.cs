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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Company/Details.cshtml")]
    public partial class _Views_Company_Details_cshtml : System.Web.Mvc.WebViewPage<Advertise.ViewModel.Models.Companies.CompanyDetailsViewModel>
    {
        public _Views_Company_Details_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Company\Details.cshtml"
  
    ViewBag.Title = "جزئیات";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>CompanyDetailsViewModel</h4>\r\n    <hr />\r\n" +
"    <dl");

WriteLiteral(" class=\"dl-horizontal\"");

WriteLiteral(">\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 14 "..\..\Views\Company\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Code));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 18 "..\..\Views\Company\Details.cshtml"
       Write(Html.DisplayFor(model => model.Code));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 22 "..\..\Views\Company\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BrandName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 26 "..\..\Views\Company\Details.cshtml"
       Write(Html.DisplayFor(model => model.BrandName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 30 "..\..\Views\Company\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 34 "..\..\Views\Company\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 38 "..\..\Views\Company\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LogoFileName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 42 "..\..\Views\Company\Details.cshtml"
       Write(Html.DisplayFor(model => model.LogoFileName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 46 "..\..\Views\Company\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BackgroundFileName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 50 "..\..\Views\Company\Details.cshtml"
       Write(Html.DisplayFor(model => model.BackgroundFileName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 54 "..\..\Views\Company\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 58 "..\..\Views\Company\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 62 "..\..\Views\Company\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MobileNumber));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 66 "..\..\Views\Company\Details.cshtml"
       Write(Html.DisplayFor(model => model.MobileNumber));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 70 "..\..\Views\Company\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 74 "..\..\Views\Company\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 78 "..\..\Views\Company\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WebSite));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 82 "..\..\Views\Company\Details.cshtml"
       Write(Html.DisplayFor(model => model.WebSite));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 86 "..\..\Views\Company\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeCount));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 90 "..\..\Views\Company\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeCount));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 94 "..\..\Views\Company\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EstablishedOn));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 98 "..\..\Views\Company\Details.cshtml"
       Write(Html.DisplayFor(model => model.EstablishedOn));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n");

WriteLiteral("    ");

            
            #line 104 "..\..\Views\Company\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

            
            #line default
            #line hidden
WriteLiteral(" |\r\n");

WriteLiteral("    ");

            
            #line 105 "..\..\Views\Company\Details.cshtml"
Write(Html.ActionLink("Back to List", "List"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</p>\r\n");

        }
    }
}
#pragma warning restore 1591