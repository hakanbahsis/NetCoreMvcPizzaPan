#pragma checksum "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\CompanyInfo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63ea52c50a40d126c2ac7e68ad940be6323c4682"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CompanyInfo_Index), @"mvc.1.0.view", @"/Views/CompanyInfo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63ea52c50a40d126c2ac7e68ad940be6323c4682", @"/Views/CompanyInfo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cb30ed3a378aada80453f74f02322888ebfbe09", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CompanyInfo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CompanyInfo>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\CompanyInfo\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Bilgi Listesi</h1>
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Başlık</th>
        <th>Telefon Numarası</th>
        <th>Mail Adresi</th>
        <th>Adres</th>
        <th>Çalışma Günleri</th>
        <th>Çalışma Saatleri</th>
        <th>Harita Bilgisi</th>
        
        <th>Sil</th>
        <th>Güncelle</th>
    </tr>
");
#nullable restore
#line 22 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\CompanyInfo\Index.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\CompanyInfo\Index.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\CompanyInfo\Index.cshtml"
           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\CompanyInfo\Index.cshtml"
           Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\CompanyInfo\Index.cshtml"
           Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\CompanyInfo\Index.cshtml"
           Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\CompanyInfo\Index.cshtml"
           Write(item.OpenningDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\CompanyInfo\Index.cshtml"
           Write(item.OpenningHours);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\CompanyInfo\Index.cshtml"
           Write(item.MapInfo.Substring(0,50));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 908, "\"", 965, 2);
            WriteAttributeValue("", 915, "/CompanyInfo/DeleteCompanyInfo/", 915, 31, true);
#nullable restore
#line 34 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\CompanyInfo\Index.cshtml"
WriteAttributeValue("", 946, item.CompanyInfoId, 946, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1022, "\"", 1079, 2);
            WriteAttributeValue("", 1029, "/CompanyInfo/UpdateCompanyInfo/", 1029, 31, true);
#nullable restore
#line 35 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\CompanyInfo\Index.cshtml"
WriteAttributeValue("", 1060, item.CompanyInfoId, 1060, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\CompanyInfo\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 39 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\CompanyInfo\Index.cshtml"
 if (ViewBag.CountInfo==0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <td><a href=\"/CompanyInfo/AddCompanyInfo/\" class=\"btn btn-success\">Yeni Kategori Ekle</a></td>\r\n");
#nullable restore
#line 42 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\CompanyInfo\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CompanyInfo>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591