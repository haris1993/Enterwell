#pragma checksum "C:\Users\Haris\Desktop\Faktura_Test\Faktura_Test.Web\Areas\Customer\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e82aeded366fbf01bb2c97f787a40723bf47d05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Details), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\Haris\Desktop\Faktura_Test\Faktura_Test.Web\Areas\Customer\Views\_ViewImports.cshtml"
using Uplift;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Haris\Desktop\Faktura_Test\Faktura_Test.Web\Areas\Customer\Views\_ViewImports.cshtml"
using Uplift.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Haris\Desktop\Faktura_Test\Faktura_Test.Web\Areas\Customer\Views\Home\Details.cshtml"
using Uplift.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Haris\Desktop\Faktura_Test\Faktura_Test.Web\Areas\Customer\Views\Home\Details.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Haris\Desktop\Faktura_Test\Faktura_Test.Web\Areas\Customer\Views\Home\Details.cshtml"
using Uplift.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e82aeded366fbf01bb2c97f787a40723bf47d05", @"/Areas/Customer/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d20650ecd3c45bcf138399e9ebb0ebf3bb34cba", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Uplift.Models.StavkeFaktura>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success form-control  btn-square btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary form-control  btn-square btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Haris\Desktop\Faktura_Test\Faktura_Test.Web\Areas\Customer\Views\Home\Details.cshtml"
   ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container backgroundWhite\">\r\n    <div class=\"card\">\r\n        <div class=\"card-header bg-light text-light ml-0 row container\">\r\n            <div class=\"col-12 col-md-6\">\r\n                <h1 class=\"text-primary\">Kategorija: ");
#nullable restore
#line 14 "C:\Users\Haris\Desktop\Faktura_Test\Faktura_Test.Web\Areas\Customer\Views\Home\Details.cshtml"
                                                Write(Model.KategorijaProizvoda.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n            <div class=\"col-12 col-md-6 text-md-right\">\r\n                <h1 class=\"text-muted\">Ukupno: ");
#nullable restore
#line 17 "C:\Users\Haris\Desktop\Faktura_Test\Faktura_Test.Web\Areas\Customer\Views\Home\Details.cshtml"
                                           Write((Model.Cijena * Model.Faktura.Kolicina).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
            </div>
        </div>
        <div class=""card-body"">
            <div class=""container rounded p-2"">
                <div class=""row"">
                    <div class=""col-12 col-lg-8"">
                        <div class=""row"">
                            <div class=""col-12"">
                                <h3 class=""text-success"">Cijena po proizvodu: ");
#nullable restore
#line 26 "C:\Users\Haris\Desktop\Faktura_Test\Faktura_Test.Web\Areas\Customer\Views\Home\Details.cshtml"
                                                                         Write(Model.Cijena.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <h4 class=\"text-muted\">Proizvod: ");
#nullable restore
#line 27 "C:\Users\Haris\Desktop\Faktura_Test\Faktura_Test.Web\Areas\Customer\Views\Home\Details.cshtml"
                                                            Write(Model.Proizvod.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p class=\"text-secondary\">Opis: ");
#nullable restore
#line 28 "C:\Users\Haris\Desktop\Faktura_Test\Faktura_Test.Web\Areas\Customer\Views\Home\Details.cshtml"
                                                           Write(Html.Raw(Model.Opis));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-12 col-lg-4 text-center\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1498, "\"", 1520, 1);
#nullable restore
#line 33 "C:\Users\Haris\Desktop\Faktura_Test\Faktura_Test.Web\Areas\Customer\Views\Home\Details.cshtml"
WriteAttributeValue("", 1504, Model.Slika_Url, 1504, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""100%"" class=""rounded"" />
                    </div>

                </div>

            </div>
        </div>
        <div class=""card-footer"">
            <div class=""row"">
                <div class=""col-12 col-md-6 pb-1"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e82aeded366fbf01bb2c97f787a40723bf47d059141", async() => {
                WriteLiteral("Nazad");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-12 col-md-6 pb-1\">\r\n");
#nullable restore
#line 46 "C:\Users\Haris\Desktop\Faktura_Test\Faktura_Test.Web\Areas\Customer\Views\Home\Details.cshtml"
                       var AddToCartEnabled = true;

                                    if (HttpContextAccessor.HttpContext.Session.GetObject<List<int>>(SD.SessionCart) != null)
                                    {
                                        var sessionList = HttpContextAccessor.HttpContext.Session.GetObject<List<int>>(SD.SessionCart);
                                        if (sessionList.Contains(Model.Id))
                                        {
                                            AddToCartEnabled = false;
                                        }
                                    } 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\Users\Haris\Desktop\Faktura_Test\Faktura_Test.Web\Areas\Customer\Views\Home\Details.cshtml"
                     if (AddToCartEnabled)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e82aeded366fbf01bb2c97f787a40723bf47d0511682", async() => {
                WriteLiteral("Dodaj u košaru");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-serviceId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\Haris\Desktop\Faktura_Test\Faktura_Test.Web\Areas\Customer\Views\Home\Details.cshtml"
                                                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["serviceId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-serviceId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["serviceId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\Haris\Desktop\Faktura_Test\Faktura_Test.Web\Areas\Customer\Views\Home\Details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"btn btn-primary btn-square form-control btn-lg\" style=\"height:50px\" disabled>U košari</button>\r\n");
#nullable restore
#line 64 "C:\Users\Haris\Desktop\Faktura_Test\Faktura_Test.Web\Areas\Customer\Views\Home\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Uplift.Models.StavkeFaktura> Html { get; private set; }
    }
}
#pragma warning restore 1591
