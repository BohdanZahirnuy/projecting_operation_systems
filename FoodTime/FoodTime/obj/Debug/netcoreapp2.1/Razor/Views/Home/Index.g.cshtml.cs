#pragma checksum "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "180f83525226e33169595a8fb43907a5561a6296"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\_ViewImports.cshtml"
using FoodTime;

#line default
#line hidden
#line 4 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
using FoodTime.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"180f83525226e33169595a8fb43907a5561a6296", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ebf4a1dc4f8437f8770ecd4859e528abe6377f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FoodTime.Models.FoodViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: white; font-weight: bold;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 1em;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("productImg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/pizza.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/kisspng-shopping-cart-computer-icons-scalable-vector-graph-login-5c5d24d4484df5.0922957315496081482962.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
            BeginContext(115, 388, true);
            WriteLiteral(@"<link href=""THE REFERENCE FILE URL"" rel=""stylesheet"" type=""text/css"" />
<style>
    p {
        font-weight: bold;
        font-size: 16px;
    }

    label {
        font-weight: bold;
        color: black;
    }

    .productImg {
        border: 2px solid black;
        border-radius: 15%;
        box-shadow: 6px 6px gray;
    }
</style>
<div class=""container"">

");
            EndContext();
#line 26 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
      
        ViewBag.Title = "Index";
    

#line default
#line hidden
            BeginContext(552, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 29 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
     if (Model.FirstOrDefault() == null)
    {

#line default
#line hidden
            BeginContext(601, 72, true);
            WriteLiteral("        <h2 class=\"text-center text-danger\">There is no food yet!</h2>\r\n");
            EndContext();
#line 32 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
    }

    else
    {



#line default
#line hidden
            BeginContext(703, 259, true);
            WriteLiteral(@"        <div class=""row"">

            <h3 style=""margin-bottom: 2em; margin-right: 1em;""><strong>Sort by:</strong></h3>

            <button type=""button"" class=""btn btn-success"" style=""height: 3em; margin-top: 1em; margin-right: 1em;"">
                ");
            EndContext();
            BeginContext(962, 165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aab1c8c4522349bba92ff0ba683fdb6d", async() => {
                BeginContext(1074, 40, false);
#line 43 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
                                                                                                                          Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1114, 9, true);
                WriteLiteral(" desc/asc");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
                                               WriteLiteral(ViewData["NameSortParm"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1127, 158, true);
            WriteLiteral("\r\n            </button>\r\n            <button type=\"button\" class=\"btn btn-success\" style=\"height: 3em; margin-top: 1em; margin-right: 1em;\">\r\n                ");
            EndContext();
            BeginContext(1285, 167, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "264df342cbdc4a9785673ff9e7adb5f9", async() => {
                BeginContext(1398, 41, false);
#line 46 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
                                                                                                                           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(1439, 9, true);
                WriteLiteral(" desc/asc");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
                                               WriteLiteral(ViewData["PriceSortParm"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1452, 158, true);
            WriteLiteral("\r\n            </button>\r\n            <button type=\"button\" class=\"btn btn-success\" style=\"height: 3em; margin-top: 1em; margin-right: 1em;\">\r\n                ");
            EndContext();
            BeginContext(1610, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebad42ec42194acb9683c83e8101e08b", async() => {
                BeginContext(1726, 44, false);
#line 49 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
                                                                                                                              Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
                EndContext();
                BeginContext(1770, 12, true);
                WriteLiteral(" pizza/sushi");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
                                               WriteLiteral(ViewData["CategorySortParm"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1786, 39, true);
            WriteLiteral("\r\n            </button>\r\n\r\n            ");
            EndContext();
            BeginContext(1825, 481, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d1112311c1743328c1179d2609d1008", async() => {
                BeginContext(1888, 150, true);
                WriteLiteral("\r\n                <div class=\"form-actions no-color\">\r\n                    <p>\r\n                        Search: <input type=\"text\" name=\"SearchString\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2038, "\"", 2072, 1);
#line 55 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
WriteAttributeValue("", 2046, ViewData["currentFilter"], 2046, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2073, 119, true);
                WriteLiteral(" />\r\n                        <input type=\"submit\" value=\"Search\" class=\"btn btn-default\" /> |\r\n                        ");
                EndContext();
                BeginContext(2192, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a689f182097d418cb1d227c47dbb61c8", async() => {
                    BeginContext(2214, 17, true);
                    WriteLiteral("Back to Full List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2235, 64, true);
                WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2306, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 63 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {



#line default
#line hidden
            BeginContext(2412, 138, true);
            WriteLiteral("                <div class=\"col-4\" style=\"font-size:1.3em;\" id=\"dish\">\r\n                    <div class=\"col-12\">\r\n                        ");
            EndContext();
            BeginContext(2550, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "df5d6460bc5f4dc282a689fc12d66da0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2601, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2627, 195, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e5bb947cf6948ba969d41733ecbc5b2", async() => {
                BeginContext(2664, 77, true);
                WriteLiteral("\r\n                            <div class=\"row\"><h3 style=\"font-weight:bold;\">");
                EndContext();
                BeginContext(2742, 39, false);
#line 71 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(2781, 37, true);
                WriteLiteral("</h3></div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2636, "~/Home/FoodDetail/", 2636, 18, true);
#line 70 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2654, item.Id, 2654, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2822, 46, true);
            WriteLiteral("\r\n                        <div class=\"row\"><p>");
            EndContext();
            BeginContext(2869, 44, false);
#line 73 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Componets));

#line default
#line hidden
            EndContext();
            BeginContext(2913, 83, true);
            WriteLiteral("<p></div>\r\n                        <div class=\"row\"><p style=\"font-style: italic;\">");
            EndContext();
            BeginContext(2997, 44, false);
#line 74 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.ExtraInfo));

#line default
#line hidden
            EndContext();
            BeginContext(3041, 106, true);
            WriteLiteral("</p></div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-6\"><p> ");
            EndContext();
            BeginContext(3148, 42, false);
#line 76 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
                                              Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
            EndContext();
            BeginContext(3190, 35, true);
            WriteLiteral(" : <label style=\"font-weight:bold\">");
            EndContext();
            BeginContext(3226, 41, false);
#line 76 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
                                                                                                                            Write(Html.DisplayFor(modelItem => item.Weight));

#line default
#line hidden
            EndContext();
            BeginContext(3267, 74, true);
            WriteLiteral(" гр</label></p></div>\r\n                            <div class=\"col-6\"><p> ");
            EndContext();
            BeginContext(3342, 41, false);
#line 77 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
                                              Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3383, 35, true);
            WriteLiteral(" : <label style=\"font-weight:bold\">");
            EndContext();
            BeginContext(3419, 40, false);
#line 77 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
                                                                                                                           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3459, 56, true);
            WriteLiteral(" $</label></p></div>\r\n\r\n                        </div>\r\n");
            EndContext();
#line 80 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
            BeginContext(3603, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=", 3633, "", 3688, 1);
#line 82 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
WriteAttributeValue("", 3639, Url.Action("Cart", "Home", new { id = item.Id }), 3639, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3688, 111, true);
            WriteLiteral(">\r\n                                <div class=\"row\" id=\"add_to_cart_btn\">\r\n                                    ");
            EndContext();
            BeginContext(3799, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e486d6f59d8241be8a1d2edee711716e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3936, 133, true);
            WriteLiteral("\r\n                                    <p>Add to cart </p>\r\n                                </div>\r\n                            </a>\r\n");
            EndContext();
#line 88 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4096, 52, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n");
            EndContext();
#line 91 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"

            }

#line default
#line hidden
            BeginContext(4165, 33, true);
            WriteLiteral("\r\n            }\r\n        </div>\r\n");
            EndContext();
#line 96 "C:\Users\Asus\Documents\GitHub\projecting_programming_systems\FoodTime\FoodTime\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(4205, 12, true);
            WriteLiteral("</div>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FoodTime.Models.FoodViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
