#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.NavigationField
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
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
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/NavigationField/Read.ProgressBar.cshtml")]
    public partial class Read_ProgressBar : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.NavigationField.NavigationFieldViewModel>
    {
        public Read_ProgressBar()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 9 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
  
    var totalPages = Model.Pages.Count();

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 309), Tuple.Create("\"", 332)
            
            #line 13 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
, Tuple.Create(Tuple.Create("", 317), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 317), false)
);

WriteLiteral(" data-sf-role=\"navigation-field-container\"");

WriteLiteral(">\n\n    <div");

WriteLiteral(" class=\"progress\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"progress-bar\"");

WriteLiteral(" data-sf-role=\"progress-bar\"");

WriteLiteral("></div>\n    </div>\n\n    <span");

WriteLiteral(" class=\"sf-Progress-percent\"");

WriteLiteral(" data-sf-role=\"progress-percent\"");

WriteLiteral("> </span>\n\n    <ol");

WriteLiteral(" data-sf-role=\"sr-progressbar\"");

WriteLiteral(" class=\"sf-Progress-page-title\"");

WriteLiteral(" tabindex=\"0\"");

WriteLiteral(" role=\"progressbar\"");

WriteLiteral(" aria-valuemin=\"1\"");

WriteAttribute("aria-valuemax", Tuple.Create(" aria-valuemax=\"", 684), Tuple.Create("\"", 711)
            
            #line 21 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
                                                       , Tuple.Create(Tuple.Create("", 700), Tuple.Create<System.Object, System.Int32>(totalPages
            
            #line default
            #line hidden
, 700), false)
);

WriteLiteral(" aria-valuenow=\"1\"");

WriteAttribute("aria-valuetext", Tuple.Create(" aria-valuetext=\"", 730), Tuple.Create("\"", 768)
, Tuple.Create(Tuple.Create("", 747), Tuple.Create("Step", 747), true)
, Tuple.Create(Tuple.Create(" ", 751), Tuple.Create("1", 752), true)
, Tuple.Create(Tuple.Create(" ", 753), Tuple.Create("of", 754), true)
            
            #line 21 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
                                                                                                               , Tuple.Create(Tuple.Create(" ", 756), Tuple.Create<System.Object, System.Int32>(totalPages
            
            #line default
            #line hidden
, 757), false)
);

WriteLiteral(">\n");

            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
        
            
            #line default
            #line hidden
            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
         foreach (var page in Model.Pages)
        {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" data-sf-navigation-index=\"");

            
            #line 24 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
                                     Write(page.Index);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\n                <span");

WriteLiteral(" data-sf-page-title=\"");

            
            #line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
                                     Write(page.Title);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">");

            
            #line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
                                                  Write(Html.HtmlSanitize(page.Title));

            
            #line default
            #line hidden
WriteLiteral("</span>\n            </li>\n");

            
            #line 27 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ol>\n</div>\n\n");

            
            #line 31 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.ProgressBar.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/NavigationField/navigation-field.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591
