#pragma checksum "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Product/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a72b3f25b176538423455afdf6c0464fd4594cc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ShoppingWebApp.Views.Product.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
namespace ShoppingWebApp.Views.Product
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a72b3f25b176538423455afdf6c0464fd4594cc0", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f1a700698b8811faf213ea0e241023787dc06c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingWebApp.ViewModels.ProductListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Product/List.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"content\">\r\n\r\n    <section id=\"shop\" class=\"container\">\r\n\r\n        <div class=\"row\">\r\n\r\n            <!-- sidebar start -->\r\n            <div id=\"sidebar\" class=\"col-md-3\">\r\n\r\n                <div class=\"widget\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a72b3f25b176538423455afdf6c0464fd4594cc03911", async() => {
                WriteLiteral(@"
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control input-lg"" placeholder=""Search..."">
                            <span class=""input-group-btn"">
                                <button class=""btn btn-default btn-lg"" type=""submit""><i class=""fa fa-search""></i></button>
                            </span>
                        </div>

                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n\r\n                ");
#nullable restore
#line 27 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Product/List.cshtml"
           Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                ");
#nullable restore
#line 29 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Product/List.cshtml"
           Write(await Component.InvokeAsync("FeaturedProducts"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


            </div>
            <!-- sidebar end -->
            <!-- right column start -->
            <div class=""col-md-9"">

                <div class=""row"">

                    <div class=""col-md-12 wow fadeIn"" style=""visibility: visible; animation-name: fadeIn;"">
                        <div class=""row product-results"">
                            <div class=""product-results"">
                                <div class=""col-xs-8"">
                                    <p class=""woocommerce-result-count"">
                                        There are ");
#nullable restore
#line 44 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Product/List.cshtml"
                                             Write(Model.PagingInfo.TotalItems);

#line default
#line hidden
#nullable disable
            WriteLiteral(" products\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n");
#nullable restore
#line 51 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Product/List.cshtml"
                     foreach (var product in Model.Products)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Product/List.cshtml"
                   Write(Html.Partial("_ProductItem", product));

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Product/List.cshtml"
                                                              
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <div");
            BeginWriteAttribute("page-model", " page-model=\"", 1981, "\"", 2011, 1);
#nullable restore
#line 58 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Product/List.cshtml"
WriteAttributeValue("", 1994, Model.PagingInfo, 1994, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" page-action=\"List\"></div>\r\n\r\n            </div>\r\n            <!-- right column end -->\r\n\r\n        </div>\r\n\r\n\r\n\r\n    </section>\r\n\r\n\r\n\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingWebApp.ViewModels.ProductListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
