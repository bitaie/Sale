#pragma checksum "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4acc34cb75870a674a2114f990d9b3a21bf6f95e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoices_Details), @"mvc.1.0.view", @"/Views/Invoices/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Invoices/Details.cshtml", typeof(AspNetCore.Views_Invoices_Details))]
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
#line 1 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#line 2 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4acc34cb75870a674a2114f990d9b3a21bf6f95e", @"/Views/Invoices/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d79ad08d11418ded2b13adb4a9b2619d15bb23", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoices_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sale.Domain.Invoices.Invoice>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(82, 91, true);
            WriteLiteral("\r\n    <h2> Invoice Details</h2>\r\n\r\n<div>\r\n   \r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n");
            EndContext();
            BeginContext(275, 26, true);
            WriteLiteral("        <dt>\r\n            ");
            EndContext();
            BeginContext(302, 54, false);
#line 17 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(356, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(400, 50, false);
#line 20 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(450, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(494, 53, false);
#line 23 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(547, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(591, 49, false);
#line 26 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(640, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(684, 46, false);
#line 29 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(730, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(774, 42, false);
#line 32 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(816, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(862, 45, false);
#line 36 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AddedDate));

#line default
#line hidden
            EndContext();
            BeginContext(907, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(951, 41, false);
#line 39 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml"
       Write(Html.DisplayFor(model => model.AddedDate));

#line default
#line hidden
            EndContext();
            BeginContext(992, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1036, 48, false);
#line 42 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ModifiedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1084, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1128, 44, false);
#line 45 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml"
       Write(Html.DisplayFor(model => model.ModifiedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1172, 338, true);
            WriteLiteral(@"
        </dd>
    </dl>
</div>
<table class=""table itemTable "" id=""div_to_load_PartialView"">
    <thead>
        <tr>
            <th>Name </th>
            <th>Brand</th>

            <th>Quantity </th>

            <th>Price $ </th>

            <th></th>

        </tr>
    </thead>
    <tbody id=""Invoice_Items "">
");
            EndContext();
#line 64 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml"
         if (Model.Items != null)
                        {
        

#line default
#line hidden
#line 66 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml"
         foreach (var item in Model.Items)
                            {



#line default
#line hidden
            BeginContext(1651, 11, true);
            WriteLiteral("        <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1662, "\"", 1686, 1);
#line 70 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml"
WriteAttributeValue("", 1670, item.Product.Id, 1670, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1687, 2, true);
            WriteLiteral(" ,");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1689, "\"", 1712, 1);
#line 70 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml"
WriteAttributeValue("", 1696, item.Product.Id, 1696, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1713, 37, true);
            WriteLiteral(">\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1751, 47, false);
#line 72 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1798, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1854, 48, false);
#line 75 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(1902, 72, true);
            WriteLiteral("\r\n            </td>\r\n            <td class=\"Quantity\">\r\n                ");
            EndContext();
            BeginContext(1975, 43, false);
#line 78 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(2018, 69, true);
            WriteLiteral("\r\n            </td>\r\n            <td class=\"Price\">\r\n                ");
            EndContext();
            BeginContext(2088, 40, false);
#line 81 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2128, 41, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n");
            EndContext();
            BeginContext(2266, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 89 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml"
                            }

#line default
#line hidden
#line 89 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml"
                             
                        }

#line default
#line hidden
            BeginContext(2360, 37, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2398, 54, false);
#line 95 "C:\Users\b.khodakarami\source\repos\Sale.FrontEnd\Views\Invoices\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2452, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2460, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0552ed497d2d4f3885b72a60cfefd80d", async() => {
                BeginContext(2482, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(2498, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sale.Domain.Invoices.Invoice> Html { get; private set; }
    }
}
#pragma warning restore 1591