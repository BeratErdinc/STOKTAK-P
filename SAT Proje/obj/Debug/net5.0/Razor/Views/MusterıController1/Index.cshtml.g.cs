#pragma checksum "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\MusterıController1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3edeaca52bb86b2f1aded8e505299e4c37fb5924"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MusterıController1_Index), @"mvc.1.0.view", @"/Views/MusterıController1/Index.cshtml")]
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
#line 1 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\MusterıController1\Index.cshtml"
using SAT_Proje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3edeaca52bb86b2f1aded8e505299e4c37fb5924", @"/Views/MusterıController1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b3054a31a1e840b48ba79bac3435d2361159c6d", @"/Views/_ViewImports.cshtml")]
    public class Views_MusterıController1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Musterı>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\MusterıController1\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Admin/Index.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-bordered"">
    <tr>
        <td>MüsteriId</td>
        <th>MüsteriAdıSoyadı</th>
        <th>MüsteriAcıkAdres</th>
        <th>MüsteriSehir</th>
        <th>Siparis Durum</th>
        <th>Müsteritel</th>
        <th>Gönderilcek Ürün </th>
        <th>Delete</th>
        <th>Update </th>



    </tr>
");
#nullable restore
#line 23 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\MusterıController1\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 26 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\MusterıController1\Index.cshtml"
   Write(x.MusterıId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 27 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\MusterıController1\Index.cshtml"
   Write(x.MusterıAdıSoyadı);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 28 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\MusterıController1\Index.cshtml"
   Write(x.MusterıAcıkAdres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 29 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\MusterıController1\Index.cshtml"
   Write(x.MusterıSehır);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 30 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\MusterıController1\Index.cshtml"
   Write(x.SıparıDurum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 31 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\MusterıController1\Index.cshtml"
   Write(x.Musterıtel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 32 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\MusterıController1\Index.cshtml"
   Write(x.urun.UrunAdı);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 736, "\"", 779, 2);
            WriteAttributeValue("", 743, "/MusterıController1/Sil/", 743, 24, true);
#nullable restore
#line 33 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\MusterıController1\Index.cshtml"
WriteAttributeValue("", 767, x.MusterıId, 767, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 828, "\"", 875, 2);
            WriteAttributeValue("", 835, "/MusterıController1/Düzenle/", 835, 28, true);
#nullable restore
#line 34 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\MusterıController1\Index.cshtml"
WriteAttributeValue("", 863, x.MusterıId, 863, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n\r\n</tr>\r\n");
#nullable restore
#line 37 "C:\Users\elaku\Desktop\Yeni klasör\SAT Proje\SAT Proje\Views\MusterıController1\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
