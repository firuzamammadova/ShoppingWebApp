#pragma checksum "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Shared/Components/FeaturedProducts/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21c69a464f6a541ef9ae9a5211c27d69abad2cbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ShoppingWebApp.Views.Shared.Components.FeaturedProducts.Views_Shared_Components_FeaturedProducts_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FeaturedProducts/Default.cshtml")]
namespace ShoppingWebApp.Views.Shared.Components.FeaturedProducts
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
#line 3 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/_ViewImports.cshtml"
using ShoppingWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c69a464f6a541ef9ae9a5211c27d69abad2cbe", @"/Views/Shared/Components/FeaturedProducts/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f1a700698b8811faf213ea0e241023787dc06c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_FeaturedProducts_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShoppingWebApp.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"widget\">\r\n    <h4>FEATURED</h4>\r\n\r\n    <div class=\"products-list\">\r\n\r\n");
#nullable restore
#line 8 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Shared/Components/FeaturedProducts/Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"media\">\r\n                <a class=\"media-left\" href=\"#\">\r\n                    <img");
            BeginWriteAttribute("alt", " alt=\"", 290, "\"", 296, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive product-thumb\"");
            BeginWriteAttribute("src", " src=\"", 334, "\"", 371, 2);
            WriteAttributeValue("", 340, "/images/products/tn/", 340, 20, true);
#nullable restore
#line 12 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Shared/Components/FeaturedProducts/Default.cshtml"
WriteAttributeValue("", 360, item.Image, 360, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n                <div class=\"media-body\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21c69a464f6a541ef9ae9a5211c27d69abad2cbe5310", async() => {
#nullable restore
#line 17 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Shared/Components/FeaturedProducts/Default.cshtml"
                                                                Write(item.ProductName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Shared/Components/FeaturedProducts/Default.cshtml"
                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <p class=\"product-price\">$");
#nullable restore
#line 18 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Shared/Components/FeaturedProducts/Default.cshtml"
                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 21 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Shared/Components/FeaturedProducts/Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShoppingWebApp.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
