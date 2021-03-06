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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.SearchBox
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
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/SearchBox/SearchBox.cshtml")]
    public partial class SearchBox : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Search.Mvc.Models.ISearchBoxModel>
    {
        public SearchBox()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
  
    var searchTextBoxId = Guid.NewGuid();
    var searchButtonId = Guid.NewGuid();
 
            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 12 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
Write(!String.IsNullOrEmpty(Model.CssClass) ?
    Html.Raw(String.Format("<div class=\"{0} form-inline\">", HttpUtility.HtmlAttributeEncode(Model.CssClass))) :
    Html.Raw("<div class=\"form-inline\">"));

            
            #line default
            #line hidden
WriteLiteral("\n    <div");

WriteLiteral(" class=\"form-group sf-search-input-wrapper\"");

WriteLiteral(" role=\"search\"");

WriteLiteral(">\n        <input");

WriteLiteral(" type=\"search\"");

WriteAttribute("title", Tuple.Create(" title=\"", 582), Tuple.Create("\"", 619)
            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 590), Tuple.Create<System.Object, System.Int32>(Html.Resource("SearchInput")
            
            #line default
            #line hidden
, 590), false)
);

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 620), Tuple.Create("\"", 655)
            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
 , Tuple.Create(Tuple.Create("", 634), Tuple.Create<System.Object, System.Int32>(Model.BackgroundHint
            
            #line default
            #line hidden
, 634), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 656), Tuple.Create("\"", 677)
            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
                            , Tuple.Create(Tuple.Create("", 661), Tuple.Create<System.Object, System.Int32>(searchTextBoxId
            
            #line default
            #line hidden
, 661), false)
);

WriteLiteral(" class=\"form-control\"");

WriteAttribute("value", Tuple.Create(" value=\"", 699), Tuple.Create("\"", 729)
            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
                                                                           , Tuple.Create(Tuple.Create("", 707), Tuple.Create<System.Object, System.Int32>(ViewBag.SearchQuery
            
            #line default
            #line hidden
, 707), false)
);

WriteLiteral(" aria-autocomplete=\"both\"");

WriteAttribute("aria-describedby", Tuple.Create(" aria-describedby=\'", 755), Tuple.Create("\'", 802)
            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
                                                                                                                                             , Tuple.Create(Tuple.Create("", 774), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("SearchInfo")
            
            #line default
            #line hidden
, 774), false)
);

WriteLiteral("/>\n        <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary ml-2\"");

WriteAttribute("id", Tuple.Create(" id=\"", 864), Tuple.Create("\"", 886)
            
            #line 17 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 869), Tuple.Create<System.Object, System.Int32>(searchButtonId
            
            #line default
            #line hidden
, 869), false)
);

WriteLiteral(">");

            
            #line 17 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
                                                                             Write(Html.Resource("SearchLabel"));

            
            #line default
            #line hidden
WriteLiteral("</button>\n        <span");

WriteAttribute("id", Tuple.Create(" id=\'", 940), Tuple.Create("\'", 973)
            
            #line 18 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 945), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("SearchInfo")
            
            #line default
            #line hidden
, 945), false)
);

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(" hidden>When autocomplete results are available use up and down arrows to review " +
"and enter to select.</span>\n    </div>\n\t\n\t<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"resultsUrl\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1162), Tuple.Create("\"", 1189)
            
            #line 21 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1170), Tuple.Create<System.Object, System.Int32>(Model.ResultsUrl
            
            #line default
            #line hidden
, 1170), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"indexCatalogue\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1248), Tuple.Create("\"", 1279)
            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1256), Tuple.Create<System.Object, System.Int32>(Model.IndexCatalogue
            
            #line default
            #line hidden
, 1256), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"wordsMode\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1333), Tuple.Create("\"", 1370)
            
            #line 23 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1341), Tuple.Create<System.Object, System.Int32>(Model.WordsMode.ToString()
            
            #line default
            #line hidden
, 1341), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"disableSuggestions\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1433), Tuple.Create("\'", 1491)
            
            #line 24 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1441), Tuple.Create<System.Object, System.Int32>(Model.DisableSuggestions ? ("true") : ("false")
            
            #line default
            #line hidden
, 1441), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"minSuggestionLength\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1555), Tuple.Create("\"", 1591)
            
            #line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1563), Tuple.Create<System.Object, System.Int32>(Model.MinSuggestionLength
            
            #line default
            #line hidden
, 1563), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"suggestionFields\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1652), Tuple.Create("\"", 1685)
            
            #line 26 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1660), Tuple.Create<System.Object, System.Int32>(Model.SuggestionFields
            
            #line default
            #line hidden
, 1660), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"language\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1738), Tuple.Create("\"", 1763)
            
            #line 27 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1746), Tuple.Create<System.Object, System.Int32>(Model.Language
            
            #line default
            #line hidden
, 1746), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"suggestionsRoute\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1824), Tuple.Create("\"", 1857)
            
            #line 28 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1832), Tuple.Create<System.Object, System.Int32>(Model.SuggestionsRoute
            
            #line default
            #line hidden
, 1832), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchTextBoxId\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1917), Tuple.Create("\'", 1960)
            
            #line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1925), Tuple.Create<System.Object, System.Int32>("#" + searchTextBoxId.ToString()
            
            #line default
            #line hidden
, 1925), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchButtonId\"");

WriteAttribute("value", Tuple.Create(" value=\'", 2019), Tuple.Create("\'", 2061)
            
            #line 30 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 2027), Tuple.Create<System.Object, System.Int32>("#" + searchButtonId.ToString()
            
            #line default
            #line hidden
, 2027), false)
);

WriteLiteral(" />\n</div>\n\n");

WriteLiteral("\n\n");

            
            #line 35 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 36 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(ScriptRef.JQueryUI, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 38 "..\..\ResourcePackages\Bootstrap4\MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/SearchBox/Search-box.js"), "bottom", true));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
