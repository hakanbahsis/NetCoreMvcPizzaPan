#pragma checksum "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Shared\Components\_HeaderPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b907d0c166479a65b5245104789f40cac4f2401a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__HeaderPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_HeaderPartial/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b907d0c166479a65b5245104789f40cac4f2401a", @"/Views/Shared/Components/_HeaderPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cb30ed3a378aada80453f74f02322888ebfbe09", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__HeaderPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""w3l-top-header"">
    <header id=""site-header"" class=""fixed-top"">
        <div class=""container"">
            <nav class=""navbar navbar-expand-lg navbar-dark stroke"">
                <a class=""navbar-brand"" href=""/Default/Index"">
                    <span class=""fa fa-pie-chart""></span> Pizza pan
                </a>
                <!-- if logo is image enable this
                <a class=""navbar-brand"" href=""#index.html"">
                    <img src=""image-path"" alt=""Your logo"" title=""Your logo"" style=""height:35px;"" />
                </a> -->
                <button class=""navbar-toggler  collapsed bg-gradient"" type=""button"" data-toggle=""collapse"" data-target=""#navbarTogglerDemo02""
                        aria-controls=""navbarTogglerDemo02"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon fa icon-expand fa-bars""></span>
                    <span class=""navbar-toggler-icon fa icon-close fa-times""></span>

                ");
            WriteLiteral(@"</button>

                <div class=""collapse navbar-collapse"" id=""navbarTogglerDemo02"">
                    <ul class=""navbar-nav ml-auto"">
                        <li class=""nav-item index-active"">
                            <a class=""nav-link"" href=""/Default/Index"">Anasayfa <span class=""sr-only"">(current)</span></a>
                        </li>
                        <li class=""nav-item about-active"">
                            <a class=""nav-link effect-3"" href=""/Default/About"">Hakkımızda</a>
                        </li>
                        <li class=""nav-item services-active"">
                            <a class=""nav-link effect-3"" href=""/Default/Menu"">Menu</a>
                        </li>
                        <li class=""nav-item contact-active"">
                            <a class=""nav-link effect-3"" href=""/Default/Contact"">İletişim</a>
                        </li>
                        <li class=""px-4 fill-none"">
                            <a href=""#url"" class=""btn ");
            WriteLiteral(@"btn-style btn-secondary"">Online Sipariş</a>
                        </li>
                    </ul>
                    <div class=""popup"">
                        <a href=""#domain"" class=""domain"" data-toggle=""modal"" data-target=""#DomainModal"">
                            <div class=""hamburger1"">
                                <div></div>
                                <div></div>
                                <div></div>
                            </div>
                        </a>
                    </div>
                </div>
            </nav>
        </div>
    </header>
</div>");
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
