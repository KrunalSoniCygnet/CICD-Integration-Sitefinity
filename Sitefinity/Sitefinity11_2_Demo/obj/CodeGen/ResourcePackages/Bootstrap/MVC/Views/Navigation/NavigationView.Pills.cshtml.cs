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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.Navigation
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/Navigation/NavigationView.Pills.cshtml")]
    public partial class NavigationView_Pills : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.INavigationModel>
    {

#line 23 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
public System.Web.WebPages.HelperResult RenderRootLevelNode(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 24 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <li");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 766), Tuple.Create("\"", 798)
, Tuple.Create(Tuple.Create("", 774), Tuple.Create("dropdown", 774), true)

#line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create(" ", 782), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 783), false)
);

WriteLiteralTo(__razor_helper_writer, ">\n");


#line 26 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
        

#line default
#line hidden

#line 26 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
         if (node.ChildNodes.Count > 0)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <a");

WriteLiteralTo(__razor_helper_writer, " href=\"#\"");

WriteLiteralTo(__razor_helper_writer, " data-toggle=\"dropdown\"");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-toggle expandable-node\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 28 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
                                                         WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\n                <span");

WriteLiteralTo(__razor_helper_writer, " class=\"caret\"");

WriteLiteralTo(__razor_helper_writer, "></span>\n            </a>\n");

WriteLiteralTo(__razor_helper_writer, "            <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-menu\"");

WriteLiteralTo(__razor_helper_writer, ">\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 32 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(node));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\n            </ul>\n");


#line 34 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
        }
        else
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1163), Tuple.Create("\"", 1179)

#line 37 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 1170), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 1170), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 1180), Tuple.Create("\"", 1205)

#line 37 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 1189), Tuple.Create<System.Object, System.Int32>(node.LinkTarget

#line default
#line hidden
, 1189), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 37 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
                            WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\n");


#line 38 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </li>\n");


#line 40 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"


#line default
#line hidden
});

#line 40 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
}
#line default
#line hidden

#line 43 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
public System.Web.WebPages.HelperResult RenderSubLevelsRecursive(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 44 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
 
    foreach (var childNode in node.ChildNodes)
    {
        if(childNode.ChildNodes.Count > 0)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "             <li");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1480), Tuple.Create("\"", 1525)
, Tuple.Create(Tuple.Create("", 1488), Tuple.Create("dropdown-submenu", 1488), true)

#line 49 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create(" ", 1504), Tuple.Create<System.Object, System.Int32>(GetClass(childNode)

#line default
#line hidden
, 1505), false)
);

WriteLiteralTo(__razor_helper_writer, ">\n                <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1546), Tuple.Create("\"", 1567)

#line 50 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 1553), Tuple.Create<System.Object, System.Int32>(childNode.Url

#line default
#line hidden
, 1553), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 1568), Tuple.Create("\"", 1598)

#line 50 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 1577), Tuple.Create<System.Object, System.Int32>(childNode.LinkTarget

#line default
#line hidden
, 1577), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 50 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
                                          WriteTo(__razor_helper_writer, childNode.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\n                    <span");

WriteLiteralTo(__razor_helper_writer, " class=\"right-caret\"");

WriteLiteralTo(__razor_helper_writer, "></span>\n                </a>\n                <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-menu\"");

WriteLiteralTo(__razor_helper_writer, ">\n");

WriteLiteralTo(__razor_helper_writer, "                    ");


#line 54 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(childNode));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\n                </ul>\n            </li>\n");


#line 57 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
        }
        else
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <li");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1880), Tuple.Create("\"", 1908)

#line 60 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 1888), Tuple.Create<System.Object, System.Int32>(GetClass(childNode)

#line default
#line hidden
, 1888), false)
);

WriteLiteralTo(__razor_helper_writer, ">\n                <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1929), Tuple.Create("\"", 1950)

#line 61 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 1936), Tuple.Create<System.Object, System.Int32>(childNode.Url

#line default
#line hidden
, 1936), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 1951), Tuple.Create("\"", 1981)

#line 61 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 1960), Tuple.Create<System.Object, System.Int32>(childNode.LinkTarget

#line default
#line hidden
, 1960), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 61 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
                                          WriteTo(__razor_helper_writer, childNode.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\n            </li>\n");


#line 63 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
        }
    }


#line default
#line hidden
});

#line 65 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
}
#line default
#line hidden

#line 68 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
public System.Web.WebPages.HelperResult GetClass(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 69 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
 

    if (node.IsCurrentlyOpened)
    {
        

#line default
#line hidden

#line 73 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, Html.Raw("active"));


#line default
#line hidden

#line 73 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
                           ;
    }
    else if (node.HasChildOpen)
    {
        

#line default
#line hidden

#line 77 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, Html.Raw("active"));


#line default
#line hidden

#line 77 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
                           ;
    }


#line default
#line hidden
});

#line 79 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
}
#line default
#line hidden

        public NavigationView_Pills()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

WriteLiteral("\n");

            
            #line 8 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 9 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Bootstrap/js/bootstrap.min.js"), "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 396), Tuple.Create("\"", 419)
            
            #line 11 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 404), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 404), false)
);

WriteLiteral(">\n    ");

WriteLiteral("\n\n    <ul");

WriteLiteral(" class=\"nav nav-pills\"");

WriteLiteral(">\n");

            
            #line 15 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
        
            
            #line default
            #line hidden
            
            #line 15 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
         foreach (var node in Model.Nodes)
        {
            
            
            #line default
            #line hidden
            
            #line 17 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
       Write(RenderRootLevelNode(node));

            
            #line default
            #line hidden
            
            #line 17 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
                                      ;
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\n</div>\n\n");

WriteLiteral("\n");

WriteLiteral("\n");

WriteLiteral("\n");

WriteLiteral("\n");

WriteLiteral("\n");

WriteLiteral("\n");

            
            #line 81 "..\..\ResourcePackages\Bootstrap\MVC\Views\Navigation\NavigationView.Pills.cshtml"
Write(Html.Script(Url.WidgetContent("MVC/Scripts/Navigation/pills.js"), "bottom", true));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
