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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.DocumentsList
{
    
    #line 3 "..\..MVC\Views\DocumentsList\List.DocumentsList.cshtml"
    using System;
    
    #line default
    #line hidden
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
    
    #line 5 "..\..MVC\Views\DocumentsList\List.DocumentsList.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.DocumentsList;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\DocumentsList\List.DocumentsList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/DocumentsList/List.DocumentsList.cshtml")]
    public partial class List_DocumentsList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.DocumentsList.DocumentsListViewModel>
    {
        public List_DocumentsList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<ul");

WriteAttribute("class", Tuple.Create(" class=\"", 224), Tuple.Create("\"", 261)
, Tuple.Create(Tuple.Create("", 232), Tuple.Create("list-unstyled", 232), true)
            
            #line 7 "..\..MVC\Views\DocumentsList\List.DocumentsList.cshtml"
, Tuple.Create(Tuple.Create(" ", 245), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 246), false)
);

WriteLiteral(">\n\n");

            
            #line 9 "..\..MVC\Views\DocumentsList\List.DocumentsList.cshtml"
		
            
            #line default
            #line hidden
            
            #line 9 "..\..MVC\Views\DocumentsList\List.DocumentsList.cshtml"
         foreach (var item in Model.Items)
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<li");

WriteLiteral(" class=\"media\"");

WriteLiteral(">\n\t\t\t\t<div");

WriteLiteral(" class=\"media-left pr-2 pt-1\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\n\t\t\t\t\t<span");

WriteLiteral(" class=\"sf-icon-txt\"");

WriteLiteral(">\n\t\t\t\t\t\t<svg");

WriteLiteral(" class=\"sf-icon-file sf-icon-lg\"");

WriteLiteral(">\n\t\t\t\t\t\t\t<use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 473), Tuple.Create("\"", 550)
, Tuple.Create(Tuple.Create("", 486), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap4/assets/dist/sprites/solid.svg#file")
, 486), false)
);

WriteLiteral("></use>\n\t\t\t\t\t\t</svg>\n\t\t\t\t\t\t<span");

WriteAttribute("class", Tuple.Create(" class=\"", 583), Tuple.Create("\"", 660)
, Tuple.Create(Tuple.Create("", 591), Tuple.Create("sf-icon-txt-md", 591), true)
, Tuple.Create(Tuple.Create(" ", 605), Tuple.Create("sf-icon-txt-", 606), true)
            
            #line 17 "..\..MVC\Views\DocumentsList\List.DocumentsList.cshtml"
, Tuple.Create(Tuple.Create("", 618), Tuple.Create<System.Object, System.Int32>(((DocumentItemViewModel)item).Extension
            
            #line default
            #line hidden
, 618), false)
);

WriteLiteral(">");

            
            #line 17 "..\..MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                                                                                        Write(((DocumentItemViewModel)item).Extension);

            
            #line default
            #line hidden
WriteLiteral("</span>\n\t\t\t\t\t</span>\n\t\t\t\t</div>\n\t\t\t\t<div");

WriteLiteral(" class=\"media-body\"");

WriteLiteral(" role=\"group\"");

WriteLiteral(">\n\t\t\t\t\t<a");

WriteAttribute("href", Tuple.Create(" href=\"", 785), Tuple.Create("\"", 899)
            
            #line 21 "..\..MVC\Views\DocumentsList\List.DocumentsList.cshtml"
, Tuple.Create(Tuple.Create("", 792), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix)
            
            #line default
            #line hidden
, 792), false)
);

WriteLiteral(">\n\t\t\t\t\t\t\t<strong>");

            
            #line 22 "..\..MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                               Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</strong>\n\t\t\t\t\t</a>\n\t\t\t\t\t<span");

WriteLiteral(" class=\"text-muted\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 984), Tuple.Create("\"", 1028)
            
            #line 24 "..\..MVC\Views\DocumentsList\List.DocumentsList.cshtml"
, Tuple.Create(Tuple.Create("", 997), Tuple.Create<System.Object, System.Int32>(Html.Resource("FileExtension")
            
            #line default
            #line hidden
, 997), false)
);

WriteLiteral(">(");

            
            #line 24 "..\..MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                                                                       Write(((DocumentItemViewModel)item).Extension);

            
            #line default
            #line hidden
WriteLiteral(")</span>\n\n\t\t\t\t\t<div>\n\t\t\t\t\t\t<a");

WriteAttribute("href", Tuple.Create(" href=\"", 1102), Tuple.Create("\"", 1130)
            
            #line 27 "..\..MVC\Views\DocumentsList\List.DocumentsList.cshtml"
, Tuple.Create(Tuple.Create("", 1109), Tuple.Create<System.Object, System.Int32>(item.Fields.MediaUrl
            
            #line default
            #line hidden
, 1109), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 27 "..\..MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                                                   Write(Html.Resource("Download"));

            
            #line default
            #line hidden
WriteLiteral(" <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 27 "..\..MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                                                                                                    Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span></a>\n\t\t\t\t\t\t<span");

WriteLiteral(" class=\"text-muted\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 1257), Tuple.Create("\"", 1296)
            
            #line 28 "..\..MVC\Views\DocumentsList\List.DocumentsList.cshtml"
, Tuple.Create(Tuple.Create("", 1270), Tuple.Create<System.Object, System.Int32>(Html.Resource("FileSize")
            
            #line default
            #line hidden
, 1270), false)
);

WriteLiteral(">(");

            
            #line 28 "..\..MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                                                                      Write(Math.Ceiling((double)item.Fields.TotalSize / 1024) + " KB");

            
            #line default
            #line hidden
WriteLiteral(")</span>\n\t\t\t\t\t</div>\n\t\t\t\t</div>\n\t\t\t</li>\n");

            
            #line 32 "..\..MVC\Views\DocumentsList\List.DocumentsList.cshtml"
		}

            
            #line default
            #line hidden
WriteLiteral("\n</ul>\n\n");

            
            #line 36 "..\..MVC\Views\DocumentsList\List.DocumentsList.cshtml"
 if (Model.ShowPager)
{
		
            
            #line default
            #line hidden
            
            #line 38 "..\..MVC\Views\DocumentsList\List.DocumentsList.cshtml"
   Write(Html.Action("Index", "ContentPager", new
			 {
					 currentPage = Model.CurrentPage,
					 totalPagesCount = Model.TotalPagesCount.Value,
					 redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
			 }));

            
            #line default
            #line hidden
            
            #line 43 "..\..MVC\Views\DocumentsList\List.DocumentsList.cshtml"
               
}

            
            #line default
            #line hidden
WriteLiteral("\n\n");

        }
    }
}
#pragma warning restore 1591
