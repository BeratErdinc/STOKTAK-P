#pragma checksum "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "210c1a2b46e421c6f65a31d0a4df463ef58bf734"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UrunController1_Index), @"mvc.1.0.view", @"/Views/UrunController1/Index.cshtml")]
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
#line 1 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Index.cshtml"
using SAT_Proje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"210c1a2b46e421c6f65a31d0a4df463ef58bf734", @"/Views/UrunController1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b3054a31a1e840b48ba79bac3435d2361159c6d", @"/Views/_ViewImports.cshtml")]
    public class Views_UrunController1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Urun>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Admin/Index.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-bordered"">
    <tr>

        <th>ÜrünAdı</th>
        <th>ÜrünAdet</th>
        <th>ÜrünBarkod</th>
        <th>ÜrünFiyat</th>
        <th>ÜrünAcıklama </th>
        <th>Delete</th>
        <th>Update </th>
        <th>Detay </th>



    </tr>
");
#nullable restore
#line 23 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>");
#nullable restore
#line 27 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Index.cshtml"
           Write(x.UrunAdı);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Index.cshtml"
           Write(x.UrunAdet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Index.cshtml"
           Write(x.UrunBarkod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Index.cshtml"
           Write(x.UrunFıyat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Index.cshtml"
           Write(x.UrunAcıklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 662, "\"", 699, 2);
            WriteAttributeValue("", 669, "/UrunController1/Sil/", 669, 21, true);
#nullable restore
#line 34 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Index.cshtml"
WriteAttributeValue("", 690, x.UrunId, 690, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 756, "\"", 795, 2);
            WriteAttributeValue("", 763, "/UrunController1/Getir/", 763, 23, true);
#nullable restore
#line 35 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Index.cshtml"
WriteAttributeValue("", 786, x.UrunId, 786, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 858, "\"", 897, 2);
            WriteAttributeValue("", 865, "/UrunController1/Detay/", 865, 23, true);
#nullable restore
#line 36 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Index.cshtml"
WriteAttributeValue("", 888, x.UrunId, 888, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark\">Detay</a></td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\UrunController1\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Urun>> Html { get; private set; }
    }
}
#pragma warning restore 1591