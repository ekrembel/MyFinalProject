#pragma checksum "/Users/ekrem/Projects/MyFinalProject/MyFinalProject/Views/Sell/ShareDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6d80e32a65bee6d5f393717e30b7f83ab9eddf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sell_ShareDetails), @"mvc.1.0.view", @"/Views/Sell/ShareDetails.cshtml")]
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
#line 1 "/Users/ekrem/Projects/MyFinalProject/MyFinalProject/Views/_ViewImports.cshtml"
using MyFinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ekrem/Projects/MyFinalProject/MyFinalProject/Views/_ViewImports.cshtml"
using MyFinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/ekrem/Projects/MyFinalProject/MyFinalProject/Views/Sell/ShareDetails.cshtml"
using MyFinalProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6d80e32a65bee6d5f393717e30b7f83ab9eddf3", @"/Views/Sell/ShareDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65096504e83f6bcd1fe6ea02733d55fd4e535b51", @"/Views/_ViewImports.cshtml")]
    public class Views_Sell_ShareDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SharesViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Sell", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Sell", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "/Users/ekrem/Projects/MyFinalProject/MyFinalProject/Views/Sell/ShareDetails.cshtml"
  
    ViewBag.Title = "Share Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"display-4\">Shares of ");
#nullable restore
#line 7 "/Users/ekrem/Projects/MyFinalProject/MyFinalProject/Views/Sell/ShareDetails.cshtml"
                           Write(Model[0].companyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<table class=\"box-shadow\">\r\n    <tr>\r\n        <th>Symbol</th>\r\n        <th>Company</th>\r\n        <th>Share</th>\r\n        <th>Cost</th>\r\n        <th></th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "/Users/ekrem/Projects/MyFinalProject/MyFinalProject/Views/Sell/ShareDetails.cshtml"
     foreach (var share in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "/Users/ekrem/Projects/MyFinalProject/MyFinalProject/Views/Sell/ShareDetails.cshtml"
           Write(share.Symbol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "/Users/ekrem/Projects/MyFinalProject/MyFinalProject/Views/Sell/ShareDetails.cshtml"
           Write(share.companyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "/Users/ekrem/Projects/MyFinalProject/MyFinalProject/Views/Sell/ShareDetails.cshtml"
           Write(share.NumOfShare);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>$");
#nullable restore
#line 24 "/Users/ekrem/Projects/MyFinalProject/MyFinalProject/Views/Sell/ShareDetails.cshtml"
            Write(share.latestPrice.ToString("#.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6d80e32a65bee6d5f393717e30b7f83ab9eddf36576", async() => {
                WriteLiteral("\r\n                    <input name=\"symbol\" hidden");
                BeginWriteAttribute("value", " value=\"", 734, "\"", 755, 1);
#nullable restore
#line 27 "/Users/ekrem/Projects/MyFinalProject/MyFinalProject/Views/Sell/ShareDetails.cshtml"
WriteAttributeValue("", 742, share.Symbol, 742, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input class=\"btn btn-outline-danger\" type=\"submit\" value=\"Current Value\" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6d80e32a65bee6d5f393717e30b7f83ab9eddf38991", async() => {
                WriteLiteral("\r\n                    <input name=\"symbol\"");
                BeginWriteAttribute("value", " value=\"", 1040, "\"", 1061, 1);
#nullable restore
#line 33 "/Users/ekrem/Projects/MyFinalProject/MyFinalProject/Views/Sell/ShareDetails.cshtml"
WriteAttributeValue("", 1048, share.Symbol, 1048, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n                    <input name=\"numOfShare\"");
                BeginWriteAttribute("value", " value=\"", 1118, "\"", 1143, 1);
#nullable restore
#line 34 "/Users/ekrem/Projects/MyFinalProject/MyFinalProject/Views/Sell/ShareDetails.cshtml"
WriteAttributeValue("", 1126, share.NumOfShare, 1126, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n                    <input type=\"submit\" class=\"btn btn-outline-danger\" value=\"Sell\" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "/Users/ekrem/Projects/MyFinalProject/MyFinalProject/Views/Sell/ShareDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SharesViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
