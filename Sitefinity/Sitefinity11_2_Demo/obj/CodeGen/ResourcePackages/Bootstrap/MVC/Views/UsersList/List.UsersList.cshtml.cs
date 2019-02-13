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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.UsersList
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 8 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
    using Telerik.Sitefinity.Frontend.Identity.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 9 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
    using Telerik.Sitefinity.Frontend.Identity.Mvc.Models.UsersList;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 11 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
    using Telerik.Sitefinity.Modules.UserProfiles;
    
    #line default
    #line hidden
    
    #line 7 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
    using Telerik.Sitefinity.Security.Model;
    
    #line default
    #line hidden
    
    #line 10 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/UsersList/List.UsersList.cshtml")]
    public partial class List_UsersList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.UsersList.UsersListViewModel>
    {
        public List_UsersList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 500), Tuple.Create("\"", 534)
            
            #line 13 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
, Tuple.Create(Tuple.Create("", 508), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 508), false)
, Tuple.Create(Tuple.Create(" ", 523), Tuple.Create("media-list", 524), true)
);

WriteLiteral(">\n");

            
            #line 14 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 14 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
     if (Model.ContentType == typeof(SitefinityProfile))
    {
        foreach (var item in Model.Items)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"media sf-media\"");

WriteLiteral(">\n                <div");

WriteLiteral(" class=\"media-left sf-img-thmb\"");

WriteLiteral(">\n                    <img");

WriteLiteral(" class=\"media-object\"");

WriteAttribute("src", Tuple.Create(" src=\"", 791), Tuple.Create("\"", 855)
            
            #line 20 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
, Tuple.Create(Tuple.Create("", 797), Tuple.Create<System.Object, System.Int32>((item as SitefinityProfileItemViewModel).AvatarImageUrl
            
            #line default
            #line hidden
, 797), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 856), Tuple.Create("\"", 884)
            
            #line 20 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
                                     , Tuple.Create(Tuple.Create("", 862), Tuple.Create<System.Object, System.Int32>(item.Fields.FirstName
            
            #line default
            #line hidden
, 862), false)
);

WriteLiteral(" width=\"100\"");

WriteLiteral(" height=\"100\"");

WriteLiteral(" />\n                </div>\n\n                <div");

WriteLiteral(" class=\"media-body sf-media-body\"");

WriteLiteral(">\n                    <h3>\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1044), Tuple.Create("\"", 1209)
            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
, Tuple.Create(Tuple.Create("", 1051), Tuple.Create<System.Object, System.Int32>(UsersHelper.EncodeUrlUsername(HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage), item as SitefinityProfileItemViewModel)
            
            #line default
            #line hidden
, 1051), false)
);

WriteLiteral(">\n");

WriteLiteral("                            ");

            
            #line 26 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
                        Write(((SitefinityProfile)item.DataItem).GetUserDisplayName());

            
            #line default
            #line hidden
WriteLiteral("\n                        </a>\n                    </h3>\n                    <p>\n");

WriteLiteral("                        ");

            
            #line 30 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
                   Write(Html.HtmlSanitize((((SitefinityProfileItemViewModel)item).About)));

            
            #line default
            #line hidden
WriteLiteral("\n                    </p>\n                </div>\n\n            </div>\n");

            
            #line 35 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
        }
    }
    else
    {
        if (SystemManager.IsDesignMode)
        {
            
            
            #line default
            #line hidden
            
            #line 41 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
       Write(Html.Resource("TheSelectedTemplateCannotBeUsed"));

            
            #line default
            #line hidden
            
            #line 41 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
                                                             
        }
        else
        {
            foreach (var item in Model.Items)
            {

            
            #line default
            #line hidden
WriteLiteral("                <h3>\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1816), Tuple.Create("\"", 1910)
            
            #line 48 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
, Tuple.Create(Tuple.Create("", 1823), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage)
            
            #line default
            #line hidden
, 1823), false)
);

WriteLiteral(">\n");

WriteLiteral("                        ");

            
            #line 49 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
                   Write(UserProfilesHelper.GetUserDisplayName(item.Fields.Owner));

            
            #line default
            #line hidden
WriteLiteral("\n                    </a>\n                </h3>\n");

            
            #line 52 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
            }
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 56 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 56 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
     if (Model.ShowPager)
    {
        
            
            #line default
            #line hidden
            
            #line 58 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
   Write(Html.Action("Index", "ContentPager", new
           {
               currentPage = Model.CurrentPage,
               totalPagesCount = Model.TotalPagesCount.Value,
               redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
           }));

            
            #line default
            #line hidden
            
            #line 63 "..\..\ResourcePackages\Bootstrap\MVC\Views\UsersList\List.UsersList.cshtml"
             
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

        }
    }
}
#pragma warning restore 1591
