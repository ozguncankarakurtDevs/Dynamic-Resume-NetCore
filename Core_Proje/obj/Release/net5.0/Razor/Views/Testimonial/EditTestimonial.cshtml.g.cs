#pragma checksum "C:\Users\o.karakurt\source\repos\Core_Proje\Core_Proje\Views\Testimonial\EditTestimonial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fa183fdda607ec27a55c6eca6d35a487560f974"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Testimonial_EditTestimonial), @"mvc.1.0.view", @"/Views/Testimonial/EditTestimonial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fa183fdda607ec27a55c6eca6d35a487560f974", @"/Views/Testimonial/EditTestimonial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Testimonial_EditTestimonial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Testimonial>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\o.karakurt\source\repos\Core_Proje\Core_Proje\Views\Testimonial\EditTestimonial.cshtml"
  
    ViewData["Title"] = "EditTestimonial";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-header border-0\">\r\n    <h3 class=\"mb-0\">Referans Detay Sayfası</h3>\r\n</div>\r\n");
#nullable restore
#line 10 "C:\Users\o.karakurt\source\repos\Core_Proje\Core_Proje\Views\Testimonial\EditTestimonial.cshtml"
 using (Html.BeginForm("EditTestimonial", "Testimonial", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <p class=\"card-description\">Referans Düzenleme Paneli</p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fa183fdda607ec27a55c6eca6d35a487560f9744615", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <label>ID</label>\r\n                        ");
#nullable restore
#line 19 "C:\Users\o.karakurt\source\repos\Core_Proje\Core_Proje\Views\Testimonial\EditTestimonial.cshtml"
                   Write(Html.TextBoxFor(x => x.TestimonialID, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>Ad Soyad</label>\r\n                        ");
#nullable restore
#line 23 "C:\Users\o.karakurt\source\repos\Core_Proje\Core_Proje\Views\Testimonial\EditTestimonial.cshtml"
                   Write(Html.TextBoxFor(x => x.ClientName, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>Şirket</label>\r\n                        ");
#nullable restore
#line 27 "C:\Users\o.karakurt\source\repos\Core_Proje\Core_Proje\Views\Testimonial\EditTestimonial.cshtml"
                   Write(Html.TextBoxFor(x => x.Company, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>Başlık</label>\r\n                        ");
#nullable restore
#line 31 "C:\Users\o.karakurt\source\repos\Core_Proje\Core_Proje\Views\Testimonial\EditTestimonial.cshtml"
                   Write(Html.TextBoxFor(x => x.Title, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>Resim Yolu</label>\r\n                        ");
#nullable restore
#line 35 "C:\Users\o.karakurt\source\repos\Core_Proje\Core_Proje\Views\Testimonial\EditTestimonial.cshtml"
                   Write(Html.TextBoxFor(x => x.ImageUrl, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>Yorum</label>\r\n                        ");
#nullable restore
#line 39 "C:\Users\o.karakurt\source\repos\Core_Proje\Core_Proje\Views\Testimonial\EditTestimonial.cshtml"
                   Write(Html.TextAreaFor(x => x.Comment,8,3, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n\r\n                    <button type=\"submit\" class=\"btn btn-primary mr-2\">Kaydet</button>\r\n                    <button class=\"btn btn-dark\">İptal</button>\r\n                ");
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 48 "C:\Users\o.karakurt\source\repos\Core_Proje\Core_Proje\Views\Testimonial\EditTestimonial.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Testimonial> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
