#pragma checksum "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "100d3fc14875d9ecad70f2e70dd843474897594b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Squareroot_Squareroot), @"mvc.1.0.view", @"/Views/Squareroot/Squareroot.cshtml")]
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
#line 1 "C:\Users\HP\Repos\squarerootWebApp\Views\_ViewImports.cshtml"
using squarerootWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Repos\squarerootWebApp\Views\_ViewImports.cshtml"
using squarerootWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"100d3fc14875d9ecad70f2e70dd843474897594b", @"/Views/Squareroot/Squareroot.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edabc7782d48ffe2a98afd4f550f05cc17d7b98b", @"/Views/_ViewImports.cshtml")]
    public class Views_Squareroot_Squareroot : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Squareroot", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Sqrt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("methods", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
  
    ViewData["Title"] = "Squareroot Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">A Square root calculator</h1>\r\n</div>\r\n \r\n    <div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "100d3fc14875d9ecad70f2e70dd843474897594b4493", async() => {
                WriteLiteral("\r\n    <input type=\"number\" placeholder=\"First number\" name = \"FirstNumber\"/>\r\n    <input type=\"number\" placeholder=\"Second number\" name = \"SecondNumber\"/>\r\n\r\n    if (");
#nullable restore
#line 14 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
   Write(ViewBag.Math.sqrt(NumberOne));

#line default
#line hidden
#nullable disable
                WriteLiteral(" > ");
#nullable restore
#line 14 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
                                   Write(ViewBag.Math.sqrt(NumberTwo));

#line default
#line hidden
#nullable disable
                WriteLiteral(")\r\n        {\r\n           /<div>\r\n                <p>  The number ");
#nullable restore
#line 17 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
                           Write(NumberOne);

#line default
#line hidden
#nullable disable
                WriteLiteral(" with square root of ");
#nullable restore
#line 17 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
                                                          Write(ViewBag.NumberOne);

#line default
#line hidden
#nullable disable
                WriteLiteral(" has a higher square root than the number ");
#nullable restore
#line 17 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
                                                                                                                      Write(NumberTwo);

#line default
#line hidden
#nullable disable
                WriteLiteral(" with square root ");
#nullable restore
#line 17 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
                                                                                                                                                  Write(ViewBag.NumberTwo);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n            </div>\r\n        }\r\n            if(");
#nullable restore
#line 20 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
          Write(ViewBag.Math.sqrt(NumberOne));

#line default
#line hidden
#nullable disable
                WriteLiteral(" = ");
#nullable restore
#line 20 "C:\Users\HP\Repos\squarerootWebApp\Views\Squareroot\Squareroot.cshtml"
                                          Write(ViewBag.Math.sqrt(NumberTwo));

#line default
#line hidden
#nullable disable
                WriteLiteral(")\r\n            {\r\n                 <div>\r\n                <p>  Enter another set of number, user. </p>\r\n                 </div>\r\n\r\n    <button type=\"submit\">Submit</button>  \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591