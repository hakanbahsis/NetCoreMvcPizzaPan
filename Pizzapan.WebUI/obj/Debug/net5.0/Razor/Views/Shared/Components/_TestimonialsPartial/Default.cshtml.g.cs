#pragma checksum "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Shared\Components\_TestimonialsPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9805269cf492e36ef5f3b3eb72d0302d826ecffb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__TestimonialsPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_TestimonialsPartial/Default.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\_ViewImports.cshtml"
using Pizzapan.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\_ViewImports.cshtml"
using Pizzapan.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\_ViewImports.cshtml"
using Pizzapan.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9805269cf492e36ef5f3b3eb72d0302d826ecffb", @"/Views/Shared/Components/_TestimonialsPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cb30ed3a378aada80453f74f02322888ebfbe09", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__TestimonialsPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonial>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""w3l-testimonials"" id=""testimonials"">
    <div class=""testimonials py-5"">
        <div class=""container py-lg-5 py-md-4"">
            <div class=""title-content text-center"">
                <h6 class=""sub-title"">Referanslar</h6>
                <h3 class=""title-big"">Müşterilerimiz Bizim Hakkımızda Ne Düşünüyor?</h3>
            </div>
            <div class=""row mt-lg-5 mt-4"">
                <div class=""col-md-12 mx-auto"">
                    <div class=""owl-two owl-carousel owl-theme"">
");
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Shared\Components\_TestimonialsPartial\Default.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""item"">
                            <div class=""slider-info mt-lg-4 mt-3"">
                                <div class=""message"">
                                    <span class=""fa fa-quote-left""></span>
                                    <h5>
                                        ");
#nullable restore
#line 22 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Shared\Components\_TestimonialsPartial\Default.cshtml"
                                   Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </h5>\r\n                                    <div class=\"name mt-4\">\r\n                                        <h4>");
#nullable restore
#line 25 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Shared\Components\_TestimonialsPartial\Default.cshtml"
                                       Write(item.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                        <p>");
#nullable restore
#line 26 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Shared\Components\_TestimonialsPartial\Default.cshtml"
                                      Write(item.CustomerTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"img-circle\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1514, "\"", 1534, 1);
#nullable restore
#line 30 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Shared\Components\_TestimonialsPartial\Default.cshtml"
WriteAttributeValue("", 1520, item.ImageUrl, 1520, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid testimonial-img radius-image\" alt=\"client\">\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 34 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Shared\Components\_TestimonialsPartial\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonial>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
