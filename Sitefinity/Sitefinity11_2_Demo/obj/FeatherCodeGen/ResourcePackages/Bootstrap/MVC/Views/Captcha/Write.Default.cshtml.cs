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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.Captcha
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
    
    #line 3 "..\..MVC\Views\Captcha\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Captcha\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\Captcha\Write.Default.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Captcha/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.Captcha.CaptchaViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 7 "..\..MVC\Views\Captcha\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteLiteral(" data-sf-role=\"field-captcha-container\"");

WriteLiteral(" style=\"display:none;\"");

WriteAttribute("class", Tuple.Create(" class=\"", 322), Tuple.Create("\"", 356)
            
            #line 9 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 330), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 330), false)
, Tuple.Create(Tuple.Create(" ", 345), Tuple.Create("form-group", 346), true)
);

WriteLiteral(">\n    <div>\n        <img");

WriteLiteral(" data-sf-role=\"captcha-image\"");

WriteAttribute("src", Tuple.Create(" src=\'", 410), Tuple.Create("\'", 463)
            
            #line 11 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 416), Tuple.Create<System.Object, System.Int32>(Url.WidgetContent("assets/dist/img/dummy.jpg")
            
            #line default
            #line hidden
, 416), false)
);

WriteLiteral("/>\n");

            
            #line 12 "..\..MVC\Views\Captcha\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 12 "..\..MVC\Views\Captcha\Write.Default.cshtml"
         if (Model.EnableAudioCode)
        {

            
            #line default
            #line hidden
WriteLiteral("            <button");

WriteLiteral(" class=\"btn btn-default glyphicon glyphicon-volume-up sf-ml-m\"");

WriteLiteral(" data-sf-role=\"captcha-audio-btn\"");

WriteLiteral(" type=\"button\"");

WriteAttribute("title", Tuple.Create(" title=\"", 643), Tuple.Create("\"", 688)
            
            #line 14 "..\..MVC\Views\Captcha\Write.Default.cshtml"
                                                         , Tuple.Create(Tuple.Create("", 651), Tuple.Create<System.Object, System.Int32>(Html.Resource("CaptchaAudioTooltip")
            
            #line default
            #line hidden
, 651), false)
);

WriteLiteral("></button>\r\n");

WriteLiteral("            <audio");

WriteLiteral(" data-sf-role=\"captcha-audio\"");

WriteLiteral(" controls");

WriteLiteral(" style=\"display:none\"");

WriteLiteral(" />\r\n");

            
            #line 16 "..\..MVC\Views\Captcha\Write.Default.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\n\n    <a");

WriteLiteral(" data-sf-role=\"captcha-refresh-button\"");

WriteLiteral(">");

            
            #line 19 "..\..MVC\Views\Captcha\Write.Default.cshtml"
                                        Write(Html.Resource("NewCode"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n\n    <div");

WriteLiteral(" class=\"form-inline\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n\t\t\t<input");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1001), Tuple.Create("\'", 1076)
, Tuple.Create(Tuple.Create("", 1009), Tuple.Create("{\"required\":", 1009), true)
, Tuple.Create(Tuple.Create(" ", 1021), Tuple.Create("\"", 1022), true)
            
            #line 23 "..\..MVC\Views\Captcha\Write.Default.cshtml"
        , Tuple.Create(Tuple.Create("", 1023), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.RequiredViolationMessage
            
            #line default
            #line hidden
, 1023), false)
, Tuple.Create(Tuple.Create("", 1074), Tuple.Create("\"}", 1074), true)
);

WriteLiteral(" />\n            <label");

WriteAttribute("for", Tuple.Create(" for=\'", 1099), Tuple.Create("\'", 1130)
            
            #line 24 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1105), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textbox")
            
            #line default
            #line hidden
, 1105), false)
);

WriteLiteral(">");

            
            #line 24 "..\..MVC\Views\Captcha\Write.Default.cshtml"
                                              Write(Html.Resource("TypeCodeAbove"));

            
            #line default
            #line hidden
WriteLiteral(" </label>\n            <input");

WriteAttribute("id", Tuple.Create(" id=\'", 1191), Tuple.Create("\'", 1221)
            
            #line 25 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1196), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textbox")
            
            #line default
            #line hidden
, 1196), false)
);

WriteLiteral(" type=\"text\"");

WriteLiteral(" data-sf-role=\"captcha-input\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1263), Tuple.Create("\"", 1297)
            
            #line 25 "..\..MVC\Views\Captcha\Write.Default.cshtml"
                 , Tuple.Create(Tuple.Create("", 1270), Tuple.Create<System.Object, System.Int32>(Model.CaptchaAnswerFormKey
            
            #line default
            #line hidden
, 1270), false)
);

WriteLiteral(" required=\"required\"");

WriteLiteral(" class=\"form-control input-sm\"");

WriteLiteral("/>\n            <p");

WriteLiteral(" data-sf-role=\"invalid-captcha-input\"");

WriteLiteral("  class=\"alert alert-danger\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 27 "..\..MVC\Views\Captcha\Write.Default.cshtml"
           Write(Html.Resource("CaptchaErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </p>\n        </div>\n    </div>\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"captcha-ca\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1581), Tuple.Create("\"", 1622)
            
            #line 31 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1588), Tuple.Create<System.Object, System.Int32>(Model.CaptchaCorrectAnswerFormKey
            
            #line default
            #line hidden
, 1588), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"captcha-iv\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1677), Tuple.Create("\"", 1725)
            
            #line 32 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1684), Tuple.Create<System.Object, System.Int32>(Model.CaptchaInitializationVectorFormKey
            
            #line default
            #line hidden
, 1684), false)
);

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"captcha-k\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1779), Tuple.Create("\"", 1810)
            
            #line 33 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1786), Tuple.Create<System.Object, System.Int32>(Model.CaptchaKeyFormKey
            
            #line default
            #line hidden
, 1786), false)
);

WriteLiteral(" />\n\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"captcha-settings\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1872), Tuple.Create("\"", 1898)
            
            #line 35 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1880), Tuple.Create<System.Object, System.Int32>(Model.GenerateUrl
            
            #line default
            #line hidden
, 1880), false)
);

WriteLiteral(" />\n</div>\n\n");

            
            #line 38 "..\..MVC\Views\Captcha\Write.Default.cshtml"
 if (SystemManager.IsDesignMode)
{
    var scriptUrl = Url.WidgetContent("Mvc/Scripts/Captcha/captcha.js");
    var queryAddition = scriptUrl.Contains("?") ? "&" : "?";
    var fullScriptUrl = scriptUrl + queryAddition + string.Format("_={0}", DateTime.UtcNow.Ticks.ToString());
    

            
            #line default
            #line hidden
WriteLiteral("    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\'", 2229), Tuple.Create("\'", 2249)
            
            #line 44 "..\..MVC\Views\Captcha\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2235), Tuple.Create<System.Object, System.Int32>(fullScriptUrl
            
            #line default
            #line hidden
, 2235), false)
);

WriteLiteral("></script>\n");

            
            #line 45 "..\..MVC\Views\Captcha\Write.Default.cshtml"
}
else
{
    
            
            #line default
            #line hidden
            
            #line 48 "..\..MVC\Views\Captcha\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Captcha/captcha.js"), "bottom", false));

            
            #line default
            #line hidden
            
            #line 48 "..\..MVC\Views\Captcha\Write.Default.cshtml"
                                                                                      
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
