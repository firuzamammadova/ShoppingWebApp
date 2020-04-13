#pragma checksum "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Admin/CatalogList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "711e4d541936fa7d681e47fcd246f02907a5810b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ShoppingWebApp.Views.Admin.Views_Admin_CatalogList), @"mvc.1.0.view", @"/Views/Admin/CatalogList.cshtml")]
namespace ShoppingWebApp.Views.Admin
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
#nullable restore
#line 4 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/_ViewImports.cshtml"
using ShoppingWebApp.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"711e4d541936fa7d681e47fcd246f02907a5810b", @"/Views/Admin/CatalogList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fca04c1363b6b007505b54cf17041c9343d6943f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CatalogList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingWebApp.ViewModels.CatalogListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Admin/CatalogList.cshtml"
  
    ViewData["Title"] = "CatalogList";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2>Catalog</h2>
<hr />
<div class=""card"">
    <div class=""card-header"">
        Categories
    </div>
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>#</th>
                <th>CategoryName</th>
                <th style=""width:135px;""></th>
            </tr>
        </thead>
        <tbody id=""categories"">

");
#nullable restore
#line 22 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Admin/CatalogList.cshtml"
             foreach (var item in Model.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 25 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Admin/CatalogList.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Admin/CatalogList.cshtml"
                   Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "711e4d541936fa7d681e47fcd246f02907a5810b6802", async() => {
                WriteLiteral("\r\n                            Edit\r\n                        ");
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
#line 28 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Admin/CatalogList.cshtml"
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
            WriteLiteral("\r\n                        <button class=\"btn btn-danger btn-sm\">Delete</button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 34 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Admin/CatalogList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n\r\n    <div class=\"card-footer\">\r\n        <button class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#addCategoryModal\">Create</button>\r\n\r\n        ");
#nullable restore
#line 42 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Admin/CatalogList.cshtml"
   Write(Html.Partial("_addCategoryForm", new Category()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

            <script>$(""#addCategory"").submit(function (event) {
                    event.preventDefault();
                    var form = $(this);
                    var token = $('input[name=""__RequestVerificationToken""]', form).val();
                    var data = { categoryName: $(""#CategoryName"").val() };
                    var dataWithToken = $.extend(data, { '__RequestVerificationToken': token });
                    $.ajax({
                        url: form.attr(""action""),
                        type: ""POST"",
                        data: dataWithToken,
                        beforeSend: function () {
                            $(""#ajax-loader"").show();
                        },
                        complete: function () {
                            $(""#ajax-loader"").hide();
                        },
                        success: function (data) {
                            var html = '<tr><td>' + data.categoryId + '</td><td>' + data.categoryName + '</td><td><butt");
                WriteLiteral(@"on class=""btn btn-primary btn-sm"">Edit</button><button class=""btn btn-danger btn-sm"">Delete</button></td></tr>';
                            $(""#categories"").append(html);
                            $(""#addCategoryModal"").modal('hide');
                        },
                        error: function () {
                        }
                    });
                });</script>

        ");
            }
            );
            WriteLiteral(@"
    </div>
</div>
<hr />

<div class=""card"">
    <div class=""card-header"">
        Products
    </div>

    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>#</th>
                <th>Image</th>
                <th>ProductName</th>
                <th>IsApproved</th>
                <th>IsHome</th>
                <th>IsFeatured</th>
                <th style=""width:135px;""></th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 96 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Admin/CatalogList.cshtml"
             foreach (var item in Model.Products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th>");
#nullable restore
#line 99 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Admin/CatalogList.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "711e4d541936fa7d681e47fcd246f02907a5810b12884", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3452, "~/images/products/tn/", 3452, 21, true);
#nullable restore
#line 101 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Admin/CatalogList.cshtml"
AddHtmlAttributeValue("", 3473, item.Image, 3473, 11, false);

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
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 103 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Admin/CatalogList.cshtml"
                   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 105 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Admin/CatalogList.cshtml"
                         if (item.IsApproved)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span data-feather=\"check-square\"></span>\r\n");
#nullable restore
#line 108 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Admin/CatalogList.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span data-feather=\"x-square\"></span>\r\n");
#nullable restore
#line 112 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Admin/CatalogList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 115 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Admin/CatalogList.cshtml"
                         if (item.IsHome)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span data-feather=\"check-square\"></span>\r\n");
#nullable restore
#line 118 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Admin/CatalogList.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span data-feather=\"x-square\"></span>\r\n");
#nullable restore
#line 122 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Admin/CatalogList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 125 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Admin/CatalogList.cshtml"
                         if (item.IsFeatured)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span data-feather=\"check-square\"></span>\r\n");
#nullable restore
#line 128 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Admin/CatalogList.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span data-feather=\"x-square\"></span>\r\n");
#nullable restore
#line 132 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Admin/CatalogList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </td>
                    <td>
                        <button class=""btn btn-primary btn-sm"">Edit</button>
                        <button class=""btn btn-danger btn-sm"">Delete</button>
                    </td>
                </tr>
");
#nullable restore
#line 139 "/Users/zarifamammadova/Projects/ShoppingWebApp/ShoppingWebApp/Views/Admin/CatalogList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n    <div class=\"card-footer\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "711e4d541936fa7d681e47fcd246f02907a5810b18239", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingWebApp.ViewModels.CatalogListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591