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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.Feed
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Feed\Feed.FeedLink.cshtml"
    using Telerik.Sitefinity.Frontend.Publishing.Mvc.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/Feed/Feed.FeedLink.cshtml")]
    public partial class Feed_FeedLink : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Publishing.Mvc.Models.FeedViewModel>
    {
        public Feed_FeedLink()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 135), Tuple.Create("\"", 158)
            
            #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Feed\Feed.FeedLink.cshtml"
, Tuple.Create(Tuple.Create("", 143), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 143), false)
);

WriteLiteral(">\n");

            
            #line 6 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Feed\Feed.FeedLink.cshtml"
 if ((Model.InsertionOption == FeedInsertionOption.PageOnly || Model.InsertionOption == FeedInsertionOption.PageAndAddressBar) && !string.IsNullOrEmpty(Model.Url))
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" class=\"d-inline-flex\"");

WriteAttribute("href", Tuple.Create(" href=\"", 355), Tuple.Create("\"", 372)
            
            #line 8 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Feed\Feed.FeedLink.cshtml"
, Tuple.Create(Tuple.Create("", 362), Tuple.Create<System.Object, System.Int32>(Model.Url
            
            #line default
            #line hidden
, 362), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 373), Tuple.Create("\"", 395)
            
            #line 8 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Feed\Feed.FeedLink.cshtml"
, Tuple.Create(Tuple.Create("", 381), Tuple.Create<System.Object, System.Int32>(Model.Tooltip
            
            #line default
            #line hidden
, 381), false)
);

WriteLiteral(" ");

            
            #line 8 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Feed\Feed.FeedLink.cshtml"
                                                                  Write(Model.OpenInNewWindow ? "target=_blank" : "");

            
            #line default
            #line hidden
WriteLiteral(">\n        <svg");

WriteLiteral(" class=\"sf-icon-feed sf-icon-sm\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\n            <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 527), Tuple.Create("\"", 610)
, Tuple.Create(Tuple.Create("", 540), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap4/assets/dist/sprites/solid.svg#rss-square")
, 540), false)
);

WriteLiteral("></use>\n        </svg>\n");

WriteLiteral("        ");

            
            #line 12 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Feed\Feed.FeedLink.cshtml"
   Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("\n    </a>\n");

            
            #line 14 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Feed\Feed.FeedLink.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
