#pragma checksum "C:\Users\Antonio\Desktop\MoviesSopro-main\MoviesSopro\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54dbb7d6bb0bf398d2b96fe34e23ff02785905b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Antonio\Desktop\MoviesSopro-main\MoviesSopro\Views\_ViewImports.cshtml"
using MoviesSopro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Antonio\Desktop\MoviesSopro-main\MoviesSopro\Views\_ViewImports.cshtml"
using MoviesSopro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54dbb7d6bb0bf398d2b96fe34e23ff02785905b4", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58191beb1c11c91602c9ded2b25478bbfbf2e385", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoviesSopro.Models.MoviesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 500px; height: 450px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Actor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("actor-img-style"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Antonio\Desktop\MoviesSopro-main\MoviesSopro\Views\Movies\Details.cshtml"
  
    ViewData["Title"] = "Details";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container-fluid\" style=\"background-color: rgba(17, 17, 17,\n      0.808); color: rgb(238, 235, 235);\">\n    <div class=\"container\">\n        <div>\n            <h1");
            BeginWriteAttribute("class", " class=\"", 256, "\"", 264, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "C:\Users\Antonio\Desktop\MoviesSopro-main\MoviesSopro\Views\Movies\Details.cshtml"
                    Write(Html.DisplayFor(model => model.Movie.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n        </div>\n        <div>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "54dbb7d6bb0bf398d2b96fe34e23ff02785905b45468", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 367, "~/Photos/", 367, 9, true);
#nullable restore
#line 15 "C:\Users\Antonio\Desktop\MoviesSopro-main\MoviesSopro\Views\Movies\Details.cshtml"
AddHtmlAttributeValue("", 376, Model.Movie.PhotoURL, 376, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n        <div>\n            <div>\n");
            WriteLiteral("                <p");
            BeginWriteAttribute("class", " class=\"", 666, "\"", 674, 0);
            EndWriteAttribute();
            WriteLiteral("> IMDb rating: &nbsp; ");
#nullable restore
#line 21 "C:\Users\Antonio\Desktop\MoviesSopro-main\MoviesSopro\Views\Movies\Details.cshtml"
                                            Write(Html.DisplayFor(model => model.Movie.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p");
            BeginWriteAttribute("class", " class=\"", 765, "\"", 773, 0);
            EndWriteAttribute();
            WriteLiteral(">ShortDescription: &nbsp; ");
#nullable restore
#line 22 "C:\Users\Antonio\Desktop\MoviesSopro-main\MoviesSopro\Views\Movies\Details.cshtml"
                                                Write(Html.DisplayFor(model => model.Movie.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p");
            BeginWriteAttribute("class", " class=\"", 878, "\"", 886, 0);
            EndWriteAttribute();
            WriteLiteral(">Release Date: &nbsp; ");
#nullable restore
#line 23 "C:\Users\Antonio\Desktop\MoviesSopro-main\MoviesSopro\Views\Movies\Details.cshtml"
                                            Write(Html.DisplayFor(model => model.Movie.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p");
            BeginWriteAttribute("class", " class=\"", 982, "\"", 990, 0);
            EndWriteAttribute();
            WriteLiteral(">Language: &nbsp; ");
#nullable restore
#line 24 "C:\Users\Antonio\Desktop\MoviesSopro-main\MoviesSopro\Views\Movies\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.Movie.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
            WriteLiteral("                <p");
            BeginWriteAttribute("class", " class=\"", 1165, "\"", 1173, 0);
            EndWriteAttribute();
            WriteLiteral(">Categories: &nbsp;  ");
#nullable restore
#line 26 "C:\Users\Antonio\Desktop\MoviesSopro-main\MoviesSopro\Views\Movies\Details.cshtml"
                                           Write(Html.DisplayFor(model => model.Movie.Categories));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p");
            BeginWriteAttribute("class", " class=\"", 1267, "\"", 1275, 0);
            EndWriteAttribute();
            WriteLiteral(">Director: &nbsp;  ");
#nullable restore
#line 27 "C:\Users\Antonio\Desktop\MoviesSopro-main\MoviesSopro\Views\Movies\Details.cshtml"
                                         Write(Html.DisplayFor(model => model.Movie.DirectorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <div class=\"row\">\n");
#nullable restore
#line 29 "C:\Users\Antonio\Desktop\MoviesSopro-main\MoviesSopro\Views\Movies\Details.cshtml"
                     foreach (var actors in Model.AllActorsInMovie)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-12 col-sm-6 col-md-4 col-lg-3\">\n                            <div>\n                                <h1>");
#nullable restore
#line 33 "C:\Users\Antonio\Desktop\MoviesSopro-main\MoviesSopro\Views\Movies\Details.cshtml"
                               Write(Html.DisplayFor(item => actors.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                            </div>\n                            <div style=\"width:300px; height:300px;\">\n");
#nullable restore
#line 36 "C:\Users\Antonio\Desktop\MoviesSopro-main\MoviesSopro\Views\Movies\Details.cshtml"
                                 if (Uri.IsWellFormedUriString(actors.PhotoURL, UriKind.Absolute))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54dbb7d6bb0bf398d2b96fe34e23ff02785905b411255", async() => {
                WriteLiteral("\n                                        <div> <img");
                BeginWriteAttribute("src", " src=\"", 2057, "\"", 2079, 1);
#nullable restore
#line 39 "C:\Users\Antonio\Desktop\MoviesSopro-main\MoviesSopro\Views\Movies\Details.cshtml"
WriteAttributeValue("", 2063, actors.PhotoURL, 2063, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"actor-img-style\" /> </div>\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\Antonio\Desktop\MoviesSopro-main\MoviesSopro\Views\Movies\Details.cshtml"
                                                                                     WriteLiteral(actors.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 41 "C:\Users\Antonio\Desktop\MoviesSopro-main\MoviesSopro\Views\Movies\Details.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54dbb7d6bb0bf398d2b96fe34e23ff02785905b414493", async() => {
                WriteLiteral("\n                                        <div> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "54dbb7d6bb0bf398d2b96fe34e23ff02785905b414793", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2427, "~/ActorPhotos/", 2427, 14, true);
#nullable restore
#line 45 "C:\Users\Antonio\Desktop\MoviesSopro-main\MoviesSopro\Views\Movies\Details.cshtml"
AddHtmlAttributeValue("", 2441, actors.PhotoURL, 2441, 16, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" </div>\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\Antonio\Desktop\MoviesSopro-main\MoviesSopro\Views\Movies\Details.cshtml"
                                                                                     WriteLiteral(actors.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 47 "C:\Users\Antonio\Desktop\MoviesSopro-main\MoviesSopro\Views\Movies\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\n                        </div>\n");
#nullable restore
#line 50 "C:\Users\Antonio\Desktop\MoviesSopro-main\MoviesSopro\Views\Movies\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoviesSopro.Models.MoviesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591