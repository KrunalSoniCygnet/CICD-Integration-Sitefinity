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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.Blog
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
    using Telerik.Sitefinity.Frontend.Blogs.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
    using Telerik.Sitefinity.Frontend.Blogs.Mvc.Models.Blog;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 7 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/Blog/List.BlogList.cshtml")]
    public partial class List_BlogList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_BlogList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 311), Tuple.Create("\"", 334)
            
            #line 10 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
, Tuple.Create(Tuple.Create("", 319), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 319), false)
);

WriteLiteral(">\r\n\r\n    <ul");

WriteLiteral(" class=\"list-unstyled\"");

WriteLiteral(">\r\n");

            
            #line 13 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
        
            
            #line default
            #line hidden
            
            #line 13 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
          
            var lastPostDates = Model.GetLastPostDates();
        
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 17 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
        
            
            #line default
            #line hidden
            
            #line 17 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
         foreach (var item in Model.Items)
        {
            var detailPageUrl = DetailLocationHyperLinkHelper.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.DetailPageMode);

            
            #line default
            #line hidden
WriteLiteral("            <li ");

            
            #line 20 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
           Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n                <h3>\r\n");

            
            #line 22 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 22 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
                     if (!string.IsNullOrEmpty(detailPageUrl))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <a ");

            
            #line 24 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
                      Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(" href=\"");

            
            #line 24 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
                                                                                     Write(detailPageUrl);

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 24 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
                                                                                                     Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
                    }
                    else{

            
            #line default
            #line hidden
WriteLiteral("                        <span ");

            
            #line 27 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
                         Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 27 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
                                                                                  Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 28 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </h3>\r\n\r\n");

            
            #line 31 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
                
            
            #line default
            #line hidden
            
            #line 31 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
                  
                    var lastPostDate = item.GetLastPostDate(lastPostDates);
                    if (lastPostDate != null && lastPostDate.HasValue)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <p");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 35 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
                                         Write(Html.Resource("LastPost"));

            
            #line default
            #line hidden
WriteLiteral(" : ");

            
            #line 35 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
                                                                      Write(lastPostDate.Value.ToShortDateString());

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 36 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
                    }
                
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n            </li>\r\n");

            
            #line 40 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n\r\n");

            
            #line 43 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 43 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
     if (Model.ShowPager)
    {
        
            
            #line default
            #line hidden
            
            #line 45 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
   Write(Html.Action("Index", "ContentPager", new
   {
       currentPage = Model.CurrentPage,
       totalPagesCount = Model.TotalPagesCount.Value,
       redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
   }));

            
            #line default
            #line hidden
            
            #line 50 "..\..\ResourcePackages\Bootstrap\MVC\Views\Blog\List.BlogList.cshtml"
     
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
