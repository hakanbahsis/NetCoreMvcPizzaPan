#pragma checksum "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a34aa9a8f78df25c83afe835a56141ca06a317f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Index), @"mvc.1.0.view", @"/Views/Default/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a34aa9a8f78df25c83afe835a56141ca06a317f", @"/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cb30ed3a378aada80453f74f02322888ebfbe09", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Default\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--\r\nAuthor: W3layouts\r\nAuthor URL: http://w3layouts.com\r\n-->\r\n<!doctype html>\r\n<html lang=\"en\">\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_HeadPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a34aa9a8f78df25c83afe835a56141ca06a317f3975", async() => {
                WriteLiteral("\r\n    <!--header-->\r\n   ");
#nullable restore
#line 17 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_HeaderPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!--/header-->\r\n    <!-- Domain Modal -->\r\n    ");
#nullable restore
#line 20 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_ModalPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n   \r\n    <!-- //Domain modal -->\r\n    ");
#nullable restore
#line 23 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_DomainPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    \r\n    <!-- iphone home block -->\r\n    ");
#nullable restore
#line 26 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_AboutPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    \r\n    <!-- //iphone home block -->\r\n    ");
#nullable restore
#line 29 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_BlockPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 30 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_PortfolioPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 31 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_FoodPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n  \r\n   \r\n\r\n    <!--/testimonials-->\r\n    ");
#nullable restore
#line 36 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_TestimonialsPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!--//testimonials-->\r\n    <!-- footers 20 -->\r\n    ");
#nullable restore
#line 39 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_FooterPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <!-- move top -->\r\n    <button onclick=\"topFunction()\" id=\"movetop\" title=\"Go to top\">\r\n        &#10548;\r\n    </button>\r\n    ");
#nullable restore
#line 45 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_ScriptsPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n</html>");
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
