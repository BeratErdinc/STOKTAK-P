#pragma checksum "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Detay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "849379f7e7e8d0fae169f786a79d7887331dba81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UrunController1_Detay), @"mvc.1.0.view", @"/Views/UrunController1/Detay.cshtml")]
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
#line 1 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\_ViewImports.cshtml"
using SAT_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Detay.cshtml"
using SAT_Proje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"849379f7e7e8d0fae169f786a79d7887331dba81", @"/Views/UrunController1/Detay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b3054a31a1e840b48ba79bac3435d2361159c6d", @"/Views/_ViewImports.cshtml")]
    public class Views_UrunController1_Detay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Musterı>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Detay.cshtml"
  
    ViewData["Title"] = "Detay";
    Layout = "~/Admin/Index.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div><h2>Ürün:");
#nullable restore
#line 8 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Detay.cshtml"
         Write(ViewBag.urn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></div>\r\n\r\n<table class=\"table table-bordered\">\r\n<tr>\r\n    <td>MusterıId</td>\r\n    <th>MusterıAdıSoyadı</th>\r\n    <th>MusterıAcıkAdres</th>\r\n    <th>MusterıSehır</th>\r\n    <th>Sıparıs Durum</th>\r\n    <th>Musterıtel</th>\r\n  \r\n\r\n\r\n\r\n</tr>\r\n");
#nullable restore
#line 23 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Detay.cshtml"
 foreach (var x in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 26 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Detay.cshtml"
       Write(x.MusterıId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 27 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Detay.cshtml"
       Write(x.MusterıAdıSoyadı);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 28 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Detay.cshtml"
       Write(x.MusterıAcıkAdres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 29 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Detay.cshtml"
       Write(x.MusterıSehır);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 30 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Detay.cshtml"
       Write(x.SıparıDurum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 31 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Detay.cshtml"
       Write(x.Musterıtel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n     \r\n\r\n    </tr>\r\n");
#nullable restore
#line 35 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Detay.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Musterı>> Html { get; private set; }
    }
}
#pragma warning restore 1591
