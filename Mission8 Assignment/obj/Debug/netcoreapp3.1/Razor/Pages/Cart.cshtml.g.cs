#pragma checksum "/Users/yuze/Desktop/Mission7 Assignment/Pages/Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a11787f4176f98f5152241cdce09b4d38c645c49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookProject.Pages.Pages_Cart), @"mvc.1.0.razor-page", @"/Pages/Cart.cshtml")]
namespace BookProject.Pages
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
#line 3 "/Users/yuze/Desktop/Mission7 Assignment/Pages/_ViewImports.cshtml"
using BookProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a11787f4176f98f5152241cdce09b4d38c645c49", @"/Pages/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae1babd438247042fc8cf3ecb5b1b814e69cd03f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Your Cart</h1>\n<table class=\"table table-boardered table-striped\">\n    <thead>\n        <tr>\n            <th>BookTitle</th>\n            <th>Quantity</th>\n            <th>Price</th>\n            <th>Subtotal</th>\n        </tr>\n    </thead>\n\n    <tbody>\n");
#nullable restore
#line 18 "/Users/yuze/Desktop/Mission7 Assignment/Pages/Cart.cshtml"
         foreach (var i in Model.basket.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 21 "/Users/yuze/Desktop/Mission7 Assignment/Pages/Cart.cshtml"
               Write(i.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 22 "/Users/yuze/Desktop/Mission7 Assignment/Pages/Cart.cshtml"
               Write(i.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>$");
#nullable restore
#line 23 "/Users/yuze/Desktop/Mission7 Assignment/Pages/Cart.cshtml"
                Write(i.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 24 "/Users/yuze/Desktop/Mission7 Assignment/Pages/Cart.cshtml"
                Write((i.Quantity * @i.Book.Price).ToString("$#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 26 "/Users/yuze/Desktop/Mission7 Assignment/Pages/Cart.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n\n\n    <tfoot>\n        <tr>\n            <td colspan=\"3\">Total Price:</td>\n            <td>");
#nullable restore
#line 33 "/Users/yuze/Desktop/Mission7 Assignment/Pages/Cart.cshtml"
           Write(Model.basket.CalculateTotal().ToString("$#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n    </tfoot>\n    <tfoot>\n        <tr>\n            <td colspan=\"3\" class=\"text-right\">Total Book(s): </td>\n            <td class=\"text-right\">\n                ");
#nullable restore
#line 40 "/Users/yuze/Desktop/Mission7 Assignment/Pages/Cart.cshtml"
           Write(Model.basket.TotalBook());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n    </tfoot>\n</table>\n\n<div>\n    <center>\n        <a class=\"btn btn-outline-secondary\"");
            BeginWriteAttribute("href", " href=\"", 1074, "\"", 1097, 1);
#nullable restore
#line 48 "/Users/yuze/Desktop/Mission7 Assignment/Pages/Cart.cshtml"
WriteAttributeValue("", 1081, Model.ReturnUrl, 1081, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue Shopping</a>\n    </center>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookProject.Pages.CartModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookProject.Pages.CartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookProject.Pages.CartModel>)PageContext?.ViewData;
        public BookProject.Pages.CartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
