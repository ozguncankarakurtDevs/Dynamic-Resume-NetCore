#pragma checksum "C:\Users\o.karakurt\source\repos\Core_Proje\Core_Proje\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a643e9c24a0f3bf6c43d4f494e72a7c7004cba9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#line 1 "C:\Users\o.karakurt\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\o.karakurt\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a643e9c24a0f3bf6c43d4f494e72a7c7004cba9", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\o.karakurt\source\repos\Core_Proje\Core_Proje\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a643e9c24a0f3bf6c43d4f494e72a7c7004cba93581", async() => {
                WriteLiteral("\r\n    <!-- Required meta tags -->\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <title>Corona Admin</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a643e9c24a0f3bf6c43d4f494e72a7c7004cba94747", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 15 "C:\Users\o.karakurt\source\repos\Core_Proje\Core_Proje\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("FeatureStatistics"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-4 grid-margin stretch-card"">
            <div class=""card"">
                <div class=""card-body"">
                    <h4 class=""card-title"">Bütçe Geçmişi</h4>
                    <canvas id=""transaction-history"" class=""transaction-chart""></canvas>
                    <div class=""bg-gray-dark d-flex d-md-block d-xl-flex flex-row py-3 px-4 px-md-3 px-xl-4 rounded mt-3"">
                        <div class=""text-md-center text-xl-left"">
                            <h6 class=""mb-1"">Proje Ödemeleri</h6>
                            <p class=""text-muted mb-0"">7 Aralık 2021, 09:36</p>
                        </div>
                        <div class=""align-self-center flex-grow text-right text-md-center text-xl-right py-md-2 py-xl-0"">
                            <h6 class=""font-weight-bold mb-0"">₺12450</h6>
                        </div>
                    </div>
                    <div class=""bg-gray-dark d-flex d-md-block d-xl-flex flex-row py-3 ");
                WriteLiteral(@"px-4 px-md-3 px-xl-4 rounded mt-3"">
                        <div class=""text-md-center text-xl-left"">
                            <h6 class=""mb-1"">Reklam Gelirleri</h6>
                            <p class=""text-muted mb-0"">1 Aralık 2021, 16:30</p>
                        </div>
                        <div class=""align-self-center flex-grow text-right text-md-center text-xl-right py-md-2 py-xl-0"">
                            <h6 class=""font-weight-bold mb-0"">$1687</h6>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        ");
#nullable restore
#line 43 "C:\Users\o.karakurt\source\repos\Core_Proje\Core_Proje\Views\Dashboard\Index.cshtml"
   Write(await Component.InvokeAsync("Last5Projects"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    ");
#nullable restore
#line 45 "C:\Users\o.karakurt\source\repos\Core_Proje\Core_Proje\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("StatisticsDashboard2"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 47 "C:\Users\o.karakurt\source\repos\Core_Proje\Core_Proje\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("ProjectList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <div class=\"row\">\r\n\r\n        ");
#nullable restore
#line 51 "C:\Users\o.karakurt\source\repos\Core_Proje\Core_Proje\Views\Dashboard\Index.cshtml"
   Write(await Component.InvokeAsync("MessageList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 53 "C:\Users\o.karakurt\source\repos\Core_Proje\Core_Proje\Views\Dashboard\Index.cshtml"
   Write(await Component.InvokeAsync("SlideList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 55 "C:\Users\o.karakurt\source\repos\Core_Proje\Core_Proje\Views\Dashboard\Index.cshtml"
   Write(await Component.InvokeAsync("ToDoListPanel"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n\r\n    </div>\r\n    ");
#nullable restore
#line 60 "C:\Users\o.karakurt\source\repos\Core_Proje\Core_Proje\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("VisitorMap"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
