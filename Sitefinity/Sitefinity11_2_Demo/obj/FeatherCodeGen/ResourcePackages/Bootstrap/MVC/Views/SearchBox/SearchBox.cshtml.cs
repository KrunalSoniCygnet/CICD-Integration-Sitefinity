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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.SearchBox
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
    
    #line 5 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/SearchBox/SearchBox.cshtml")]
    public partial class SearchBox : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Search.Mvc.Models.ISearchBoxModel>
    {
        public SearchBox()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 7 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
  
    var searchTextBoxId = Guid.NewGuid();
    var searchButtonId = Guid.NewGuid();
 
            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 12 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
Write(!String.IsNullOrEmpty(Model.CssClass) ?
    Html.Raw(String.Format("<div class=\"{0} form-inline\">", HttpUtility.HtmlAttributeEncode(Model.CssClass))) :
    Html.Raw("<div class=\"form-inline\">"));

            
            #line default
            #line hidden
WriteLiteral("\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n        <input");

WriteLiteral(" type=\"search\"");

WriteAttribute("title", Tuple.Create(" title=\"", 544), Tuple.Create("\"", 581)
            
            #line 16 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 552), Tuple.Create<System.Object, System.Int32>(Html.Resource("SearchInput")
            
            #line default
            #line hidden
, 552), false)
);

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 582), Tuple.Create("\"", 617)
            
            #line 16 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
 , Tuple.Create(Tuple.Create("", 596), Tuple.Create<System.Object, System.Int32>(Model.BackgroundHint
            
            #line default
            #line hidden
, 596), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 618), Tuple.Create("\"", 639)
            
            #line 16 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
                            , Tuple.Create(Tuple.Create("", 623), Tuple.Create<System.Object, System.Int32>(searchTextBoxId
            
            #line default
            #line hidden
, 623), false)
);

WriteLiteral(" class=\"form-control\"");

WriteAttribute("value", Tuple.Create(" value=\"", 661), Tuple.Create("\"", 691)
            
            #line 16 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
                                                                           , Tuple.Create(Tuple.Create("", 669), Tuple.Create<System.Object, System.Int32>(ViewBag.SearchQuery
            
            #line default
            #line hidden
, 669), false)
);

WriteLiteral("/>\n    </div>\n    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteAttribute("id", Tuple.Create(" id=\"", 755), Tuple.Create("\"", 777)
            
            #line 18 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 760), Tuple.Create<System.Object, System.Int32>(searchButtonId
            
            #line default
            #line hidden
, 760), false)
);

WriteLiteral(">");

            
            #line 18 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
                                                                    Write(Html.Resource("SearchLabel"));

            
            #line default
            #line hidden
WriteLiteral("</button>\n\t\n\t<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"resultsUrl\"");

WriteAttribute("value", Tuple.Create(" value=\"", 867), Tuple.Create("\"", 894)
            
            #line 20 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 875), Tuple.Create<System.Object, System.Int32>(Model.ResultsUrl
            
            #line default
            #line hidden
, 875), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"indexCatalogue\"");

WriteAttribute("value", Tuple.Create(" value=\"", 953), Tuple.Create("\"", 984)
            
            #line 21 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 961), Tuple.Create<System.Object, System.Int32>(Model.IndexCatalogue
            
            #line default
            #line hidden
, 961), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"wordsMode\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1038), Tuple.Create("\"", 1075)
            
            #line 22 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1046), Tuple.Create<System.Object, System.Int32>(Model.WordsMode.ToString()
            
            #line default
            #line hidden
, 1046), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"disableSuggestions\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1138), Tuple.Create("\'", 1196)
            
            #line 23 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1146), Tuple.Create<System.Object, System.Int32>(Model.DisableSuggestions ? ("true") : ("false")
            
            #line default
            #line hidden
, 1146), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"minSuggestionLength\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1260), Tuple.Create("\"", 1296)
            
            #line 24 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1268), Tuple.Create<System.Object, System.Int32>(Model.MinSuggestionLength
            
            #line default
            #line hidden
, 1268), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"suggestionFields\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1357), Tuple.Create("\"", 1390)
            
            #line 25 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1365), Tuple.Create<System.Object, System.Int32>(Model.SuggestionFields
            
            #line default
            #line hidden
, 1365), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"language\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1443), Tuple.Create("\"", 1468)
            
            #line 26 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1451), Tuple.Create<System.Object, System.Int32>(Model.Language
            
            #line default
            #line hidden
, 1451), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"suggestionsRoute\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1529), Tuple.Create("\"", 1562)
            
            #line 27 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1537), Tuple.Create<System.Object, System.Int32>(Model.SuggestionsRoute
            
            #line default
            #line hidden
, 1537), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchTextBoxId\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1622), Tuple.Create("\'", 1665)
            
            #line 28 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1630), Tuple.Create<System.Object, System.Int32>("#" + searchTextBoxId.ToString()
            
            #line default
            #line hidden
, 1630), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchButtonId\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1724), Tuple.Create("\'", 1766)
            
            #line 29 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1732), Tuple.Create<System.Object, System.Int32>("#" + searchButtonId.ToString()
            
            #line default
            #line hidden
, 1732), false)
);

WriteLiteral(" />\n</div>\n\n");

WriteLiteral("\n\n");

            
            #line 34 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 35 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(ScriptRef.JQueryUI, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 37 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/SearchBox/Search-box.js"), "bottom", true));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
