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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.Reviews
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
    
    #line 3 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Reviews/Reviews.Default.cshtml")]
    public partial class Reviews_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Comments.Mvc.Models.CommentsListViewModel>
    {
        public Reviews_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 6 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteAttribute("id", Tuple.Create(" id=\"", 223), Tuple.Create("\"", 277)
, Tuple.Create(Tuple.Create("", 228), Tuple.Create("comments-", 228), true)
            
            #line 7 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 237), Tuple.Create<System.Object, System.Int32>(HttpUtility.HtmlEncode(Model.ThreadKey)
            
            #line default
            #line hidden
, 237), false)
);

WriteLiteral(" data-sf-role=\"comments-wrapper\"");

WriteAttribute("class", Tuple.Create(" class=\"", 310), Tuple.Create("\"", 356)
            
            #line 7 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                    , Tuple.Create(Tuple.Create("", 318), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 318), false)
, Tuple.Create(Tuple.Create(" ", 333), Tuple.Create("sf-Comments", 334), true)
, Tuple.Create(Tuple.Create(" ", 345), Tuple.Create("sf-Reviews", 346), true)
);

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"comments-settings\"");

WriteAttribute("value", Tuple.Create(" value=\"", 417), Tuple.Create("\"", 456)
            
            #line 8 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 425), Tuple.Create<System.Object, System.Int32>(Model.SerializedWidgetSettings
            
            #line default
            #line hidden
, 425), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"comments-resources\"");

WriteAttribute("value", Tuple.Create(" value=\"", 520), Tuple.Create("\"", 560)
            
            #line 9 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 528), Tuple.Create<System.Object, System.Int32>(Model.SerializedWidgetResources
            
            #line default
            #line hidden
, 528), false)
);

WriteLiteral(" />\r\n\r\n    <div");

WriteLiteral(" class=\"row sf-Comments-header\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-lg-7\"");

WriteLiteral(">\r\n\r\n            <h3>\r\n                <span");

WriteLiteral(" data-sf-role=\"comments-total-count\"");

WriteLiteral("></span>\r\n                <span");

WriteLiteral(" data-sf-role=\"comments-header\"");

WriteLiteral("></span>\r\n            </h3>\r\n\r\n");

            
            #line 19 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 19 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
             if (!Model.ThreadIsClosed)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 886), Tuple.Create("\"", 972)
, Tuple.Create(Tuple.Create("", 893), Tuple.Create("#comment-submit-", 893), true)
            
            #line 21 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 909), Tuple.Create<System.Object, System.Int32>(HttpUtility.HtmlEncode(HttpUtility.UrlEncode(Model.ThreadKey))
            
            #line default
            #line hidden
, 909), false)
);

WriteLiteral(" data-sf-role=\"comments-new-form-button\"");

WriteLiteral(">");

            
            #line 21 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                                             Write(Html.Resource("WriteReview"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 22 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" data-sf-role=\"comments-count-list-wrapper\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 25 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                    Write(Html.Resource("AverageRating"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("                ");

            
            #line 26 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
           Write(Html.CommentsCount(string.Empty, Model.ThreadKey, Model.ThreadType));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </span>\r\n        </div>\r\n\r\n\r\n        <div");

WriteLiteral(" class=\"col-lg-5 clearfix\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"float-right\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-sf-role=\"comments-sort-new-button\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral("><span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 33 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                           Write(Html.Resource("OrderBy"));

            
            #line default
            #line hidden
WriteLiteral(" </span>");

            
            #line 33 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                                            Write(Html.Resource("NewestOnTop"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-sf-role=\"comments-sort-old-button\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral("><span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 34 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                           Write(Html.Resource("OrderBy"));

            
            #line default
            #line hidden
WriteLiteral(" </span>");

            
            #line 34 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                                            Write(Html.Resource("OldestOnTop"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" data-sf-role=\"list-loading-indicator\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral("></div>\r\n    <ul");

WriteLiteral(" data-sf-role=\"comments-container\"");

WriteLiteral(" class=\"sf-Comments-list list-unstyled\"");

WriteLiteral("></ul>\r\n\r\n");

            
            #line 42 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 42 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
     if (Model.EnablePaging)
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-sf-role=\"comments-load-more-button\"");

WriteLiteral(">");

            
            #line 44 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                        Write(Html.Resource("LoadMoreReviews"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 45 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 47 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 47 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
     if (Model.ThreadIsClosed)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-warning\"");

WriteLiteral(">");

            
            #line 49 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                    Write(Html.Resource("ReviewsThreadIsClosedMessage"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 50 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"sf-Comments-form\"");

WriteLiteral(">\r\n\r\n            <div");

WriteLiteral(" data-sf-role=\"comments-new-form\"");

WriteAttribute("id", Tuple.Create(" id=\"", 2389), Tuple.Create("\"", 2449)
, Tuple.Create(Tuple.Create("", 2394), Tuple.Create("comment-submit-", 2394), true)
            
            #line 55 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2409), Tuple.Create<System.Object, System.Int32>(HttpUtility.HtmlEncode(Model.ThreadKey)
            
            #line default
            #line hidden
, 2409), false)
);

WriteLiteral(" class=\"sf-Comments-form\"");

WriteLiteral(">\r\n");

            
            #line 56 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                
            
            #line default
            #line hidden
            
            #line 56 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                 if (Model.RequiresApproval)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"alert alert-warning\"");

WriteLiteral(" data-sf-role=\"comments-new-pending-approval-message\"");

WriteLiteral(">");

            
            #line 58 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                     Write(Html.Resource("ReviewPendingApproval"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 59 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"media sf-media\"");

WriteLiteral(">\r\n\r\n                    <div");

WriteLiteral(" class=\"media-left sf-img-thmb\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 2870), Tuple.Create("\"", 2901)
            
            #line 64 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2876), Tuple.Create<System.Object, System.Int32>(Model.UserAvatarImageUrl
            
            #line default
            #line hidden
, 2876), false)
);

WriteLiteral(" width=\"40\"");

WriteLiteral(" height=\"40\"");

WriteLiteral(" alt=\"User avatar\"");

WriteLiteral(" />\r\n                    </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"media-body sf-media-body\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                            <label");

WriteAttribute("for", Tuple.Create(" for=\"", 3122), Tuple.Create("\"", 3158)
            
            #line 69 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3128), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CommentInput")
            
            #line default
            #line hidden
, 3128), false)
);

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 69 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                   Write(Html.Resource("WriteReview"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                            <textarea");

WriteAttribute("id", Tuple.Create(" id=\"", 3252), Tuple.Create("\"", 3287)
            
            #line 70 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3257), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CommentInput")
            
            #line default
            #line hidden
, 3257), false)
);

WriteLiteral(" aria-required=\"true\"");

WriteLiteral(" data-sf-role=\"comments-new-message\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 3345), Tuple.Create("\"", 3388)
            
            #line 70 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                , Tuple.Create(Tuple.Create("", 3359), Tuple.Create<System.Object, System.Int32>(Html.Resource("WriteReview")
            
            #line default
            #line hidden
, 3359), false)
);

WriteLiteral(" class=\"form-control\"");

WriteLiteral("></textarea>\r\n                        </div>\r\n\r\n                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                            <fieldset");

WriteLiteral(" class=\"sf-Ratings\"");

WriteLiteral(" role=\"radiogroup\"");

WriteLiteral(" aria-required=\"true\"");

WriteLiteral(">\r\n                                <legend");

WriteAttribute("id", Tuple.Create(" id=\"", 3645), Tuple.Create("\"", 3680)
            
            #line 75 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3650), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RatingLegend")
            
            #line default
            #line hidden
, 3650), false)
);

WriteLiteral(">");

            
            #line 75 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                       Write(Html.Resource("Rating"));

            
            #line default
            #line hidden
WriteLiteral("</legend>\r\n                                <div");

WriteLiteral(" data-sf-role=\"submit-rating-container\"");

WriteLiteral(" class=\"sf-Ratings-stars\"");

WriteAttribute("id", Tuple.Create(" id=\"", 3817), Tuple.Create("\"", 3851)
            
            #line 76 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                         , Tuple.Create(Tuple.Create("", 3822), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RatingStars")
            
            #line default
            #line hidden
, 3822), false)
);

WriteLiteral(">\r\n                                </div>\r\n                            </fieldset" +
">\r\n                        </div>\r\n\r\n                        <div");

WriteLiteral(" data-sf-role=\"comments-new-logged-out-view\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(">\r\n\r\n                            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                <label");

WriteAttribute("for", Tuple.Create(" for=\"", 4161), Tuple.Create("\"", 4193)
            
            #line 84 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 4167), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("YourName")
            
            #line default
            #line hidden
, 4167), false)
);

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">");

            
            #line 84 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                          Write(Html.Resource("YourName"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                <input");

WriteAttribute("id", Tuple.Create(" id=\"", 4308), Tuple.Create("\"", 4339)
            
            #line 85 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 4313), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("YourName")
            
            #line default
            #line hidden
, 4313), false)
);

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 4340), Tuple.Create("\"", 4380)
            
            #line 85 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
    , Tuple.Create(Tuple.Create("", 4354), Tuple.Create<System.Object, System.Int32>(Html.Resource("YourName")
            
            #line default
            #line hidden
, 4354), false)
);

WriteLiteral(" data-sf-role=\"comments-new-name\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n                            </div>\r\n\r\n                            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                <label");

WriteAttribute("for", Tuple.Create(" for=\"", 4570), Tuple.Create("\"", 4603)
            
            #line 89 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 4576), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("YourEmail")
            
            #line default
            #line hidden
, 4576), false)
);

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">");

            
            #line 89 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                           Write(Html.Resource("EmailOptional"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                <input");

WriteAttribute("id", Tuple.Create(" id=\"", 4723), Tuple.Create("\"", 4755)
            
            #line 90 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 4728), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("YourEmail")
            
            #line default
            #line hidden
, 4728), false)
);

WriteLiteral(" type=\"email\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 4769), Tuple.Create("\"", 4814)
            
            #line 90 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                  , Tuple.Create(Tuple.Create("", 4783), Tuple.Create<System.Object, System.Int32>(Html.Resource("EmailOptional")
            
            #line default
            #line hidden
, 4783), false)
);

WriteLiteral(" data-sf-role=\"comments-new-email\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n                            </div>\r\n                        </div>\r\n\r\n");

            
            #line 94 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 94 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                         if (Model.RequiresCaptcha)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" data-sf-role=\"captcha-container\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(" class=\"sf-Comments-captcha\"");

WriteLiteral(">\r\n                                <div>\r\n                                    <im" +
"g");

WriteLiteral(" data-sf-role=\"captcha-image\"");

WriteAttribute("src", Tuple.Create(" src=\"", 5251), Tuple.Create("\"", 5304)
            
            #line 98 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 5257), Tuple.Create<System.Object, System.Int32>(Url.WidgetContent("assets/dist/img/dummy.jpg")
            
            #line default
            #line hidden
, 5257), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\r\n                                </div>\r\n\r\n                                <a" +
"");

WriteLiteral(" data-sf-role=\"captcha-refresh-button\"");

WriteLiteral("> ");

            
            #line 101 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                     Write(Html.Resource("NewCode"));

            
            #line default
            #line hidden
WriteLiteral(" </a>\r\n\r\n                                <div");

WriteLiteral(" class=\"form-inline\"");

WriteLiteral(">\r\n\r\n                                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                        <label");

WriteAttribute("for", Tuple.Create(" for=\"", 5636), Tuple.Create("\"", 5667)
            
            #line 106 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 5642), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Captcha")
            
            #line default
            #line hidden
, 5642), false)
);

WriteLiteral(">");

            
            #line 106 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                          Write(Html.Resource("TypeCodeAbove"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                        <input");

WriteAttribute("id", Tuple.Create(" id=\"", 5756), Tuple.Create("\"", 5786)
            
            #line 107 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 5761), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Captcha")
            
            #line default
            #line hidden
, 5761), false)
);

WriteLiteral(" type=\"text\"");

WriteLiteral(" data-sf-role=\"captcha-input\"");

WriteLiteral(" class=\"form-control input-sm\"");

WriteLiteral(" />\r\n                                    </div>\r\n\r\n                              " +
"  </div>\r\n                            </div>\r\n");

            
            #line 112 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div>\r\n                            <button");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" data-sf-role=\"comments-new-submit-button\"");

WriteLiteral(">");

            
            #line 115 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                 Write(Html.Resource("Submit"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n      " +
"          </div>\r\n\r\n            </div>\r\n\r\n");

            
            #line 124 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 124 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
             if (Model.AllowSubscription)
                {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"sf-Comment-subscribe\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" data-sf-role=\"comments-subscribe-text\"");

WriteLiteral("></span>\r\n                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-sf-role=\"comments-subscribe-button\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"sf-icon-email\"");

WriteLiteral("></span>\r\n                        <span");

WriteLiteral(" data-sf-role=\"comments-subscribe-button-text\"");

WriteLiteral("></span>\r\n                    </a>\r\n                </div>\r\n");

            
            #line 133 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"form-text\"");

WriteLiteral("></span>\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" data-sf-role=\"submit-loading-indicator\"");

WriteLiteral(" class=\"sf-loading\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral("></div>\r\n\r\n\r\n        </div>\r\n");

            
            #line 143 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-warning sf-Review-already\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" data-sf-role=\"review-new-form-replacement\"");

WriteLiteral(">");

            
            #line 144 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                                    Write(Html.Resource("UserAlreadySubmitedReview"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 145 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"

        if (Model.RequiresAuthentication)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"alert alert-warning\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" data-sf-role=\"comments-new-requires-authentication\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\'", 7450), Tuple.Create("\'", 7476)
            
            #line 148 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                             , Tuple.Create(Tuple.Create("", 7457), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl
            
            #line default
            #line hidden
, 7457), false)
);

WriteLiteral(">");

            
            #line 148 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                                                             Write(Html.Resource("Login"));

            
            #line default
            #line hidden
WriteLiteral("</a>");

            
            #line 148 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                                                                                        Write(Html.Resource("ToBeAbleToReview"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 149 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <template");

WriteLiteral(" data-sf-role=\"single-comment-template\"");

WriteLiteral(">\r\n\r\n        <li");

WriteLiteral(" class=\"media sf-media\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"rating-of-resource\"");

WriteAttribute("value", Tuple.Create(" value=\"", 7727), Tuple.Create("\"", 7755)
            
            #line 155 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 7735), Tuple.Create<System.Object, System.Int32>(Html.Resource("Of")
            
            #line default
            #line hidden
, 7735), false)
);

WriteLiteral(" />\r\n\r\n            <div");

WriteLiteral(" class=\"media-left sf-img-thmb\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                <img");

WriteLiteral(" data-sf-role=\"comment-avatar\"");

WriteAttribute("src", Tuple.Create(" src=\"", 7882), Tuple.Create("\"", 7935)
            
            #line 158 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 7888), Tuple.Create<System.Object, System.Int32>(Url.WidgetContent("assets/dist/img/dummy.jpg")
            
            #line default
            #line hidden
, 7888), false)
);

WriteLiteral(" width=\"40\"");

WriteLiteral(" height=\"40\"");

WriteLiteral(" alt=\"User avatar\"");

WriteLiteral(" />\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"media-body sf-media-body\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 162 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                 Write(Html.Resource("CommentBy"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                <span");

WriteLiteral(" data-sf-role=\"comment-name\"");

WriteLiteral(" class=\"text-muted sf-Comments-list-author\"");

WriteLiteral("></span>\r\n                <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 164 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                 Write(Html.Resource("From").ToLower());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                <span");

WriteLiteral(" data-sf-role=\"comment-date\"");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral("></span>\r\n\r\n                <div");

WriteLiteral(" data-sf-role=\"list-rating-wrapper\"");

WriteLiteral(" class=\"sf-Ratings\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" data-sf-role=\"list-rating-container\"");

WriteLiteral(" class=\"sf-Ratings-stars sf-Ratings-stars--ronly\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></span>\r\n                    <span");

WriteLiteral(" class=\"text-muted sf-Ratings-average\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 170 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                         Write(Html.Resource("Rating"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        <span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">(</span><span");

WriteLiteral(" data-sf-role=\"list-rating-value\"");

WriteLiteral("></span><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">)</span>\r\n                        <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(" data-sf-role=\"list-rating-sr-label\"");

WriteLiteral("></span>\r\n                    </span>\r\n                </div>\r\n\r\n                " +
"<div");

WriteLiteral(" data-sf-role=\"comment-message\"");

WriteLiteral("></div>\r\n\r\n            </div>\r\n\r\n        </li>\r\n\r\n    </template>\r\n</div>\r\n\r\n");

WriteLiteral("\r\n<div");

WriteLiteral(" data-sf-role=\"rating-template\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral("><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&#9733;</span></div>\r\n\r\n");

            
            #line 188 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Reviews/rating.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 189 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/comments-list.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
