#pragma checksum "C:\Users\Berkcan\Desktop\my-website-main\myWebsite.webui\Views\Home\Portfolyo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0da0002ee9121c95c95510a62b8b7305ef72effb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Portfolyo), @"mvc.1.0.view", @"/Views/Home/Portfolyo.cshtml")]
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
#line 1 "C:\Users\Berkcan\Desktop\my-website-main\myWebsite.webui\Views\_ViewImports.cshtml"
using myWebsite.webui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Berkcan\Desktop\my-website-main\myWebsite.webui\Views\_ViewImports.cshtml"
using myWebsite.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Berkcan\Desktop\my-website-main\myWebsite.webui\Views\_ViewImports.cshtml"
using myWebsite.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Berkcan\Desktop\my-website-main\myWebsite.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0da0002ee9121c95c95510a62b8b7305ef72effb", @"/Views/Home/Portfolyo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69aea51dcda00fac8a602dc4dc2b48ef38d7ec71", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Portfolyo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolyo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/lightgallery.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/lightgallery-all.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.mousewheel.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("CustomCss", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0da0002ee9121c95c95510a62b8b7305ef72effb5372", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <style type=""text/css"">
                
                
                .demo-gallery > ul > li {
                    float: left;
                    margin-bottom: 15px;
                    margin-right: 20px;
                    width: 200px;
                }
                .demo-gallery > ul > li a {
                  border: 3px solid #FFF;
                  border-radius: 3px;
                  display: block;
                  overflow: hidden;
                  position: relative;
                  float: left;
                }
                .demo-gallery > ul > li a > img {
                  -webkit-transition: -webkit-transform 0.15s ease 0s;
                  -moz-transition: -moz-transform 0.15s ease 0s;
                  -o-transition: -o-transform 0.15s ease 0s;
                  transition: transform 0.15s ease 0s;
                  -webkit-transform: scale3d(1, 1, 1);
                  transform: scale3d(1, 1, 1);
                  height: 100%;
                  width: 100");
                WriteLiteral(@"%;
                }
                .demo-gallery > ul > li a:hover > img {
                  -webkit-transform: scale3d(1.1, 1.1, 1.1);
                  transform: scale3d(1.1, 1.1, 1.1);
                }
                .demo-gallery > ul > li a:hover .demo-gallery-poster > img {
                  opacity: 1;
                }
                .demo-gallery > ul > li a .demo-gallery-poster {
                  background-color: rgba(0, 0, 0, 0.1);
                  bottom: 0;
                  left: 0;
                  position: absolute;
                  right: 0;
                  top: 0;
                  -webkit-transition: background-color 0.15s ease 0s;
                  -o-transition: background-color 0.15s ease 0s;
                  transition: background-color 0.15s ease 0s;
                }
                .demo-gallery > ul > li a .demo-gallery-poster > img {
                  left: 50%;
                  margin-left: -10px;
                  margin-top: -10px;
                  opacity: 0;
 ");
                WriteLiteral(@"                 position: absolute;
                  top: 50%;
                  -webkit-transition: opacity 0.3s ease 0s;
                  -o-transition: opacity 0.3s ease 0s;
                  transition: opacity 0.3s ease 0s;
                }
                .demo-gallery > ul > li a:hover .demo-gallery-poster {
                  background-color: rgba(0, 0, 0, 0.5);
                }
                .demo-gallery .justified-gallery > a > img {
                  -webkit-transition: -webkit-transform 0.15s ease 0s;
                  -moz-transition: -moz-transform 0.15s ease 0s;
                  -o-transition: -o-transform 0.15s ease 0s;
                  transition: transform 0.15s ease 0s;
                  -webkit-transform: scale3d(1, 1, 1);
                  transform: scale3d(1, 1, 1);
                  height: 100%;
                  width: 100%;
                }
                .demo-gallery .justified-gallery > a:hover > img {
                  -webkit-transform: scale3d(1.1, 1.1, 1.1);
     ");
                WriteLiteral(@"             transform: scale3d(1.1, 1.1, 1.1);
                }
                .demo-gallery .justified-gallery > a:hover .demo-gallery-poster > img {
                  opacity: 1;
                }
                .demo-gallery .justified-gallery > a .demo-gallery-poster {
                  background-color: rgba(0, 0, 0, 0.1);
                  bottom: 0;
                  left: 0;
                  position: absolute;
                  right: 0;
                  top: 0;
                  -webkit-transition: background-color 0.15s ease 0s;
                  -o-transition: background-color 0.15s ease 0s;
                  transition: background-color 0.15s ease 0s;
                }
                .demo-gallery .justified-gallery > a .demo-gallery-poster > img {
                  left: 50%;
                  margin-left: -10px;
                  margin-top: -10px;
                  opacity: 0;
                  position: absolute;
                  top: 50%;
                  -webkit-transition: opacity");
                WriteLiteral(@" 0.3s ease 0s;
                  -o-transition: opacity 0.3s ease 0s;
                  transition: opacity 0.3s ease 0s;
                }
                .demo-gallery .justified-gallery > a:hover .demo-gallery-poster {
                  background-color: rgba(0, 0, 0, 0.5);
                }
                .demo-gallery .video .demo-gallery-poster img {
                  height: 48px;
                  margin-left: -24px;
                  margin-top: -24px;
                  opacity: 0.8;
                  width: 48px;
                }
                .demo-gallery.dark > ul > li a {
                  border: 3px solid #04070a;
                }
                .home .demo-gallery {
                  padding-bottom: 80px;
                }
                
            </style>
");
            }
            );
            WriteLiteral("\n");
#nullable restore
#line 123 "C:\Users\Berkcan\Desktop\my-website-main\myWebsite.webui\Views\Home\Portfolyo.cshtml"
  
  ViewData["pageName"]="portfolyo";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
                        <div class=""row p-3 mt-2"">
                            <div class=""col-md-12 "">
                                <h3>Bazı</h3><h3 style=""color: #FFD43B;"">çalışmalarım,</h3>    
                            </div>
                        </div>
                        <div class=""demo-gallery"">
                          <ul id=""lightgallery"" class=""list-unstyled row"">
");
#nullable restore
#line 134 "C:\Users\Berkcan\Desktop\my-website-main\myWebsite.webui\Views\Home\Portfolyo.cshtml"
                             foreach (var portfolyo in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                              <li class=\"col-md-12\" data-src=\"/img/");
#nullable restore
#line 136 "C:\Users\Berkcan\Desktop\my-website-main\myWebsite.webui\Views\Home\Portfolyo.cshtml"
                                                              Write(portfolyo.ImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-sub-html=\"<h2>");
#nullable restore
#line 136 "C:\Users\Berkcan\Desktop\my-website-main\myWebsite.webui\Views\Home\Portfolyo.cshtml"
                                                                                                      Write(portfolyo.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2><p>");
#nullable restore
#line 136 "C:\Users\Berkcan\Desktop\my-website-main\myWebsite.webui\Views\Home\Portfolyo.cshtml"
                                                                                                                             Write(portfolyo.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\">\n                                <a");
            BeginWriteAttribute("href", " href=\"", 5740, "\"", 5747, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0da0002ee9121c95c95510a62b8b7305ef72effb13885", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5817, "~/img/", 5817, 6, true);
#nullable restore
#line 138 "C:\Users\Berkcan\Desktop\my-website-main\myWebsite.webui\Views\Home\Portfolyo.cshtml"
AddHtmlAttributeValue("", 5823, portfolyo.ImageUrl, 5823, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </a>\n                              </li>  \n");
#nullable restore
#line 141 "C:\Users\Berkcan\Desktop\my-website-main\myWebsite.webui\Views\Home\Portfolyo.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            \n\n                          </ul>\n                        </div>\n                        \n                    </div>              \n");
            DefineSection("CustomJs", async() => {
                WriteLiteral(@"
  <script type=""text/javascript"">
          $(document).ready(function(){
              $('#lightgallery').lightGallery();
          });
          </script>
          <script src=""https://cdn.jsdelivr.net/picturefill/2.3.1/picturefill.min.js""></script>
          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0da0002ee9121c95c95510a62b8b7305ef72effb16288", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0da0002ee9121c95c95510a62b8b7305ef72effb17392", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolyo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
